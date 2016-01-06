using System;

namespace BinAff.Utility
{

    public class Singleton<T> where T : new()
    {

        private static Object syncRoot = new Object();
        private static T instance;

        private Singleton() { }

        public static T Instantiate()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }
            }
            return instance;
        }

    }

}