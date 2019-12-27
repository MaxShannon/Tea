using System.Data.Entity;
using Model;
using System.Runtime.Remoting.Messaging;

namespace Dal
{
    public class DbContextFactory
    {
        public static DbContext GetCurrentDbContext()
        {
            //return new EntityFrameworkDataModelContainer();
            DbContext db = CallContext.GetData("DbContext") as DbContext;
            if (db == null)
            {
                db = new EntityFrameworkDataModelContainer();
                CallContext.SetData("DbContext", db);
            }

            return db;

        }
    }
}