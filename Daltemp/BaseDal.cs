using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Model;


namespace Dal
{
    public class BaseDal<T> where T : class, new()
    {
        //private readonly EntityFrameworkDataModelContainer _db = new EntityFrameworkDataModelContainer();
        private readonly DbContext _db = DbContextFactory.GetCurrentDbContext();

        public void IsUnique(string colName, string val)
        {
            //var t = _db.Set<T>();
        }

        public T Add(T model)
        {
            _db.Set<T>().Add(model);
            _db.SaveChanges();
            return model;
        }


        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda)
        {
            return _db.Set<T>().Where(whereLambda).AsQueryable();
        }

        public bool Update(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
    }
}
