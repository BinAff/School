using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace BinAff.Core
{

    public class DbConnectionPool
    {

        private static readonly Boolean IsTraceOn = ConfigurationManager.AppSettings["TraceOn"] == "Y";
        private static readonly String tracePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["Tracepath"];
        private static Utility.Log.Server traceWritter;

        private static readonly String exceptionPath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ExceptionPath"];
        private static Utility.Log.Server exceptionWritter;

        public static String ConnectionString { get; set; }
        public static Int16 PoolSize { get; set; }
        private static Object syncRoot = new Object();

        public static List<DbConnection> ConnectionList { get; private set; }

        private DbConnectionPool() { }

        static DbConnectionPool()
        {
            exceptionWritter = new Utility.Log.Server(exceptionPath, Utility.Log.Server.Type.Daily);
            if (IsTraceOn)
            {
                traceWritter = new Utility.Log.Server(tracePath, Utility.Log.Server.Type.Daily);
            }
            ConnectionList = new List<DbConnection>();
            PoolSize = Convert.ToInt16(ConfigurationManager.AppSettings["DbConnPoolSize"]);
            if (String.IsNullOrEmpty(ConnectionString))
            {
                if (String.IsNullOrEmpty(ConfigurationManager.AppSettings["ConnectionString"]))
                {
                    ConnectionString = Properties.Settings.Default.ConnectionString;
                }
                else
                {
                    ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                }
            }
        }

        public static DbConnection Instantiate()
        {
            lock (syncRoot)
            {
                if (ConnectionList.Count == 0)
                {
                    ConnectionList.Add(new SqlConnection(ConnectionString));
                    if (IsTraceOn) traceWritter.Write("Adding new connection object... Current pool size is " + ConnectionList.Count + ".");
                    ConnectionList[0].Open();
                    return ConnectionList[0];
                }
                else
                {
                    int i = 0;
                    foreach (DbConnection conn in ConnectionList)
                    {
                        i++;
                        switch (conn.State)
                        {
                            case System.Data.ConnectionState.Connecting:
                            case System.Data.ConnectionState.Executing:
                            case System.Data.ConnectionState.Fetching:
                            case System.Data.ConnectionState.Open:
                                break;
                            case System.Data.ConnectionState.Closed:
                                if (IsTraceOn) traceWritter.Write("Opening closed connection... Index: " + i + ", Current pool size is " + ConnectionList.Count + ".");
                                conn.Open();
                                return conn;
                            case System.Data.ConnectionState.Broken:
                                ConnectionList.Remove(conn);
                                break;
                        }
                    }
                    DbConnection connection = new SqlConnection(ConnectionString);
                    connection.Open();
                    if (ConnectionList.Count < PoolSize)
                    {
                        ConnectionList.Add(connection);
                        if (IsTraceOn) traceWritter.Write("Adding new connection object. Current pool size is " + ConnectionList.Count + ".");
                    }
                    else
                    {
                        exceptionWritter.Write("Connection pool overflow. Current pool size is " + ConnectionList.Count + ".");
                    }
                    return connection;
                }
            }
        }

    }

}