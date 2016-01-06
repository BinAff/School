﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BinAff.Core
{

    /// <summary>
    /// Abstract class to hold data access objects
    /// </summary>
    public abstract class Dao : IDisposable
    {

        #region Logging / Tracing member variable

        private readonly Boolean IsTraceOn = ConfigurationManager.AppSettings["TraceOn"] == "Y";
        private readonly String tracePath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["Tracepath"];
        private readonly String exceptionPath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ExceptionPath"];
        private Utility.Log.Server traceWritter;
        private Utility.Log.Server exceptionWritter;

        #endregion

        #region Properties

        /// <summary>
        /// Connection string
        /// </summary>
        public String ConnectionString { get; set; }

        /// <summary>
        /// Data object
        /// </summary>
        public Data Data { get; set; }

        /// <summary>
        /// Parent data object
        /// </summary>
        public Data ParentData { get; set; }

        /// <summary>
        /// Server attached with data access component
        /// </summary>
        public BinAff.Core.Crud Server { get; set; }

        private DbCommand command;

        private DbConnection conn;

        #endregion

        protected Dao(Data data)
        {
            this.exceptionWritter = new Utility.Log.Server(this.exceptionPath, Utility.Log.Server.Type.Daily);
            if (this.IsTraceOn)
            {
                this.traceWritter = new Utility.Log.Server(this.tracePath, Utility.Log.Server.Type.Daily);
            }
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " DAL Start...");
            this.Data = data;
            this.Compose();
        }

        #region Compose Properties

        /// <summary>
        /// Stored procedure to insert new record
        /// </summary>
        public String CreateStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to read record
        /// </summary>
        public String ReadStoredProcedure { get; set; }
        
        /// <summary>
        /// Stored procedure to read all record
        /// </summary>
        public String ReadAllStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to read all activated record
        /// </summary>
        public String ReadAllActivateStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to read record from parent reference
        /// Stored procedure should have @ParentId parameter
        /// </summary>
        public String ReadForParentStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to update record
        /// </summary>
        public String UpdateStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to update activation status of record
        /// </summary>
        public String UpdateActivationStatusStoredProcedure { get; set; }

        /// <summary>
        /// Stored procedure to delete record
        /// </summary>
        protected String DeleteStoredProcedure { get; set; }

        /// <summary>
        /// Number of rows affected after create
        /// </summary>
        protected Int64 NumberOfRowsAffectedInCreate { get; set; }

        /// <summary>
        /// Number of rows affected after update
        /// </summary>
        protected Int64 NumberOfRowsAffectedInUpdate { get; set; }

        /// <summary>
        /// Number of rows affected after update
        /// </summary>
        protected Int64 NumberOfRowsAffectedInDelete { get; set; }

        #endregion

        #region Ado.Net

        /// <summary>
        /// Create new record in database
        /// </summary>
        /// <returns></returns>
        protected virtual Int32 ExecuteNonQuery()
        {
            try
            {
                if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ExecuteNonQuery Start");
                Int32 effectedRow = this.command.ExecuteNonQuery();
                if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ExecuteNonQuery End with result " + effectedRow);
                return effectedRow;
            }
            catch (SqlException ex)
            {
                this.exceptionWritter.Write(ex, "Module: " + this.ToString());
                if (ex.ErrorCode == -2146232060) //Foreign key violation
                {
                    return ex.ErrorCode;
                }
                return -999;
            }
        }

        /// <summary>
        /// Get value from database
        /// </summary>
        /// <returns></returns>
        protected virtual String ExecuteScalar()
        {
            try
            {
                return Convert.ToString(this.command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Create new record in database
        /// </summary>
        /// <returns></returns>
        protected virtual DbDataReader ExecuteReader()
        {
            return this.command.ExecuteReader();
        }

        protected virtual DataSet ExecuteDataSet()
        {
            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(this.command as SqlCommand))
            {
                adapter.Fill(ds);
            }
            return ds;
        }

        protected virtual T ExecuteScalar<T>()
        {
            try
            {
                Object ret = this.command.ExecuteScalar();
                if (ret == null || String.IsNullOrEmpty(ret.ToString()))
                {
                    return default(T);
                }
                else
                {
                    return (T)ret;
                }
            }
            catch (SqlException ex)
            {
                this.exceptionWritter.Write(ex, "Module: " + this.ToString());
                throw;
            }
            catch (InvalidCastException ex)
            {
                this.exceptionWritter.Write(ex, "Module: " + this.ToString());
                throw;
            }
        }

        protected virtual DataTable ExecuteDataTable()
        {
            DataTable dt = new DataTable();
            new SqlDataAdapter((SqlCommand)this.command).Fill(dt);
            return dt;
        }

        /// <summary>
        /// Create new connection from App.config SqlExpress2008 connection string
        /// </summary>
        protected DbConnection CreateConnection()
        {
            if (this.conn == null)
            {
                if (!String.IsNullOrEmpty(this.ConnectionString))
                {
                    DbConnectionPool.ConnectionString = this.ConnectionString;
                }
                this.conn = DbConnectionPool.Instantiate();
                return this.conn;
            }
            else if (this.conn.State != ConnectionState.Open)
            {
                this.conn.Open();
            }
            return this.conn;
        }

        protected DbConnection GetOpenConnection()
        {
            if (this.conn != null && this.conn.State == ConnectionState.Open)
            {
                return this.conn;
            }
            return null;
        }

        protected void SetConnection(DbConnection conn)
        {
            this.conn = conn;
        }

        protected void CloseConnection()
        {
            if (this.conn != null && this.conn.State != ConnectionState.Closed)
            {
                this.conn.Close();
            }
        }

        /// <summary>
        /// Create command for database interaction
        /// </summary>
        /// <param name="spName">Name of stored procedure</param>
        /// <returns></returns>
        protected DbCommand CreateCommand(String spName)
        {
            this.CreateConnection();
            this.command = new SqlCommand(spName, this.conn as SqlConnection)
            {
                CommandType = CommandType.StoredProcedure,
            };

            return this.command;
        }

        #endregion

        protected abstract void Compose();

        #region Advanced CRUD and activator

        /// <summary>
        /// Create new record in database
        /// </summary>
        /// <returns></returns>
        public virtual Boolean Create()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Create Start");
            Boolean status = false;
            if (this.CreateStoredProcedure == null) throw new Exception("Insert stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.CreateStoredProcedure + ", Id - " + this.Data.Id);
            this.CreateConnection();
            if (this.CreateBefore())
            {
                this.CreateCommand(this.CreateStoredProcedure);
                this.AssignParameter(this.CreateStoredProcedure);
                this.AddOutParameter("@Id", DbType.Int64, this.Data.Id);
                this.command.ExecuteNonQuery();
                this.Data.Id = Convert.ToInt64(this.command.Parameters["@Id"].Value);
                if (this.Data.Id > 0) status = this.CreateAfter();
            }
            this.CloseConnection();
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Create End");
            return status;

            #region DAB
            //this.wrapper = new WrapperDac();
            //this.command = this.wrapper.GetStoredProcCommand(this.createStoredProcedure);
            //this.AssignParameter(this.createStoredProcedure);
            //this.wrapper.ExecuteNonQuery(this.command);
            //this.wrapper = null;
            //this.command = null;
            #endregion
        }

        /// <summary>
        /// Update existing record in database
        /// </summary>
        /// <returns></returns>
        public virtual Boolean Update()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Update Start");
            Boolean status = false;
            if (this.UpdateStoredProcedure == null) throw new Exception("Update stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.UpdateStoredProcedure + ", Id - " + this.Data.Id);
            this.CreateConnection();
            if (this.UpdateBefore())
            {
                this.CreateCommand(this.UpdateStoredProcedure);
                this.AddInParameter("@Id", DbType.Int64, this.Data.Id);
                this.AssignParameter(this.UpdateStoredProcedure);
                Int32 i = this.ExecuteNonQuery();
                if (i == this.NumberOfRowsAffectedInUpdate || this.NumberOfRowsAffectedInUpdate == -1)
                {
                    status = this.UpdateAfter();
                }
            }
            this.CloseConnection();
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Update End");
            return status;
            #region DAB
            //this.wrapper = new WrapperDac();
            //this.command = this.wrapper.GetStoredProcCommand(this.updateStoredProcedure);
            //this.AssignParameter(this.updateStoredProcedure);
            //bool status = this.wrapper.ExecuteNonQuery(this.command) == this.numberOfRowsAffectedInUpdate;
            //this.wrapper = null;
            //this.command = null;
            //return status;
            #endregion
        }

        /// <summary>
        /// Abstract method to override in child for Reading
        /// </summary>
        /// <returns></returns>
        public virtual Data Read()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Read Start");
            if (this.ReadStoredProcedure == null) throw new Exception("Read stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.ReadStoredProcedure + ", Id - " + this.Data.Id);
            this.CreateConnection();
            if (this.ReadBefore())
            {
                this.CreateCommand(this.ReadStoredProcedure);
                this.AddInParameter("@Id", DbType.Int64, this.Data.Id);
                DataSet ds = this.ExecuteDataSet();
                this.Data = CreateDataObject(ds, this.Data);
            }
            if (!this.ReadAfter()) this.Data = null;
            this.CloseConnection();
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Read End");
            return this.Data;
        }

        /// <summary>
        /// Read all record from database
        /// </summary>
        /// <returns></returns>
        public virtual List<BinAff.Core.Data> ReadAll()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadAll Start");
            if (this.ReadAllStoredProcedure == null) throw new Exception("ReadAll stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.ReadAllStoredProcedure);
            this.CreateCommand(this.ReadAllStoredProcedure);
            DataSet ds = this.ExecuteDataSet();
            List<BinAff.Core.Data> dataList = CreateDataObjectList(ds);
            this.CloseConnection();

            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadAll End");
            return dataList;
        }

        /// <summary>
        /// Read all record from database
        /// </summary>
        /// <returns></returns>
        public virtual List<BinAff.Core.Data> ReadAllActivate()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadAllActivate Start");
            if (this.ReadAllActivateStoredProcedure == null) throw new Exception("ReadAllActivate stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.ReadAllActivateStoredProcedure);
            this.CreateCommand(this.ReadAllActivateStoredProcedure);
            DataSet ds = this.ExecuteDataSet();
            List<BinAff.Core.Data> dataList = CreateDataObjectList(ds);
            this.CloseConnection();

            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadAllActivate End");
            return dataList;
        }

        /// <summary>
        /// Abstract method to override in child for Delete
        /// </summary>
        /// <returns></returns>
        public virtual Boolean Delete()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Delete Start");
            Boolean status = false;
            if (this.DeleteStoredProcedure == null) throw new Exception("Delete stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.DeleteStoredProcedure + ", Id - " + this.Data.Id);
            this.CreateConnection();
            if (this.DeleteBefore())
            {
                this.CreateCommand(this.DeleteStoredProcedure);
                this.AddInParameter("@Id", DbType.Int64, this.Data.Id);
                Int32 ret = this.ExecuteNonQuery();
                if (ret != -2146232060) //Foreign key violation
                {
                    if (ret == this.NumberOfRowsAffectedInDelete || this.NumberOfRowsAffectedInDelete == -1)
                    {
                        status = this.DeleteAfter();
                    }
                }
            }
            this.CloseConnection();
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " Delete End");
            return status;
            #region DAB
            //bool status;
            //this.wrapper = new WrapperDac();
            //this.command = this.wrapper.GetStoredProcCommand(this.deleteStoredProcedure);
            //this.AssignParameterForDelete();
            //status = this.wrapper.ExecuteNonQuery(this.command) == this.numberOfRowsAffectedInDelete;
            //this.wrapper = null;
            //this.command = null;
            //return status;
            #endregion
        }

        /// <summary>
        /// Update activation status of existing record in database
        /// </summary>
        /// <returns></returns>
        public virtual Boolean UpdateActivationStatus(Boolean activationStatus)
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " UpdateActivationStatus Start");
            if (this.UpdateActivationStatusStoredProcedure == null) throw new Exception("UpdateActivationStatus stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.UpdateActivationStatusStoredProcedure + ", Id - " + this.Data.Id);

            Data data = this.Data as Data;
            Boolean status = false;
            this.CreateConnection();
            if (this.UpdateActivationStatusBefore())
            {
                this.CreateCommand(this.UpdateActivationStatusStoredProcedure);
                this.AddInParameter("@Id", DbType.String, (this.Data as Data).Id);
                this.AddInParameter("@IsActive", DbType.Boolean, activationStatus);
                if (this.ExecuteNonQuery() == 1) status = this.UpdateActivationStatusAfter();
            }
            this.CloseConnection();
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " UpdateActivationStatus End");
            return status;
        }

        #endregion

        protected Boolean DeleteAndCreateForList()
        {
            Boolean retVal = false;
            retVal = this.DeleteBefore();
            if (retVal)
                retVal = this.CreateAfter();
            this.CloseConnection();
            return retVal;
        }

        public virtual Data GetDataFromParentData()
        {
            //Need to change
            this.Data.Id = 1;
            return this.Data;
        }

        /// <summary>
        /// Virtual method for reading the list of data for the given parent info
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public virtual Data ReadForParent()
        {
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadForParent Start");
            if (this.ReadForParentStoredProcedure == null) throw new Exception("Read for parent stored procedure not specified");
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " SP - " + this.ReadForParentStoredProcedure + ", Id - " + this.Data.Id);
            this.CreateCommand(this.ReadForParentStoredProcedure);
            this.AddInParameter("@ParentId", DbType.Int64, this.ParentData.Id);
            DataSet ds = this.ExecuteDataSet();
            this.CloseConnection();
            if (ds != null && ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Data = this.CreateDataObject(ds, this.Data);
                    this.Data.Id = Convert.IsDBNull(ds.Tables[0].Rows[0]["Id"]) ? 0 : Convert.ToInt64(ds.Tables[0].Rows[0]["Id"]);
                    this.AttachChildDataToParent();
                }
                else
                {
                    //TO DO :: Handle multiple data
                    this.AttachChildrenDataToParent(this.CreateDataObjectList(ds));
                }
            }
            if (this.IsTraceOn) this.traceWritter.Write(this.GetType().ToString() + " ReadForParent End");
            return this.Data;
        }

        /// <summary>
        /// Add parameters in stored procedure
        /// </summary>
        /// <param name="command">Command object</param>
        /// <param name="name">Parameter name</param>
        /// <param name="dbType">Data type of parameter</param>
        /// <param name="value">Value for the parameter</param>
        protected void AddInParameter(String name, DbType dbType, object value)
        {
            this.command.Parameters.Add(new SqlParameter(name, dbType)
            {
                Value = value,
            });
            //this.wrapper.AddInParameter(this.command, name, dbType, value);
        }

        /// <summary>
        /// Add out parameters in stored procedure
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="dbType">Data type of parameter</param>
        /// <param name="value">Value for the parameter</param>
        protected void AddOutParameter(String name, DbType dbType, object value)
        {
            this.command.Parameters.Add(new SqlParameter(name, dbType)
            {
                Direction = ParameterDirection.Output,
            });
            //this.wrapper.AddInParameter(this.command, name, dbType, value);
        }

        /// <summary>
        /// Return value stored under parameter
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <returns>Value under parameter</returns>
        protected object GetValueFromParameter(String name)
        {
            return this.command.Parameters[name].Value;
        }

        //protected DbCommand GetCommand(string procedureName)
        //{
        //    return this.wrapper.GetStoredProcCommand(procedureName);
        //}

        /// <summary>
        /// Assign parameter of stored procedure for create or update
        /// </summary>
        /// <param name="procudureName">Name of the stored procedure procedure</param>
        protected virtual void AssignParameter(string procedureName)
        {

        }

        /// <summary>
        /// Abstract method for creating data object for the given data row
        /// </summary>
        /// <param name="row">Data Set</param>
        /// <param name="data">Data object</param>
        /// <returns>Data object with data</returns>
        protected virtual List<BinAff.Core.Data> CreateDataObjectList(DataSet ds)
        {
            List<BinAff.Core.Data> ret = new List<BinAff.Core.Data>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Data data = this.CreateDataObject(row, this.Server.CreateDataObject());
                    data.Id = Convert.IsDBNull(row["Id"]) ? 0 : Convert.ToInt64(row["Id"]);
                    ret.Add(data);
                }
            }
            return ret;
        }

        /// <summary>
        /// Abstract method for creating list of data object for the given dataset
        /// </summary>
        /// <param name="ds">Data set</param>
        /// <returns>Data object with data</returns>
        protected virtual BinAff.Core.Data CreateDataObject(DataSet ds, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            DataRow row;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                row = ds.Tables[0].Rows[0];
                dt = this.CreateDataObject(row, dt) as Data;
            }
            return dt;
        }

        /// <summary>
        /// Abstract method for creating data object for the given data row
        /// </summary>
        /// <param name="dr">Data row</param>
        /// <param name="data">Data object</param>
        /// <returns>Data object with data</returns>
        protected virtual Data CreateDataObject(DataRow dr, Data data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// If ReadForParent() is used use this to attach child to parent
        /// </summary>
        protected virtual void AttachChildDataToParent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// If ReadForParent() is used use this to attach children to parent
        /// </summary>
        protected virtual void AttachChildrenDataToParent(List<Data> dataList)
        {
            throw new NotImplementedException();
        }

        #region Optional Hook

        internal protected virtual Boolean CreateBefore()
        {
            return true;
        }

        internal protected virtual Boolean CreateAfter()
        {
            return true;
        }

        internal protected virtual Boolean UpdateBefore()
        {
            return true;
        }

        internal protected virtual Boolean UpdateAfter()
        {
            return true;
        }

        internal protected virtual Boolean UpdateActivationStatusBefore()
        {
            return true;
        }

        internal protected virtual Boolean UpdateActivationStatusAfter()
        {
            return true;
        }

        internal protected virtual Boolean DeleteBefore()
        {
            return true;
        }

        internal protected virtual Boolean DeleteAfter()
        {
            return true;
        }

        internal protected virtual Boolean ReadBefore()
        {
            return true;
        }

        internal protected virtual Boolean ReadAfter()
        {
            return true;
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            if (this.conn != null && this.conn.State == ConnectionState.Open)
            {
                this.conn.Close();
            }
            this.command.Dispose();
            this.conn.Dispose();
        }

        #endregion

    }

}
