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
            if (!(CallContext.GetData("DbContext") is DbContext db))
            {
                db = new EntityFrameworkDataModelContainer();
                CallContext.SetData("DbContext", db);
            }

            return db;

        }
    }
}