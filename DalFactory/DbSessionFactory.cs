using System;
using System.Runtime.Remoting.Messaging;
using Dal;
using IDal;

namespace DalFactory
{
    public class DbSessionFactory
    {
        public static IDbSession GetCurrentDbSession()
        {
            if (!(CallContext.GetData("DbSession") is IDbSession db))
            {
                db = new DbSession();
                CallContext.SetData("DbSession", db);
            }

            return db;
        }
    }
}