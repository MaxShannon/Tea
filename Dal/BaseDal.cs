using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Dal
{
    public class BaseDal<T> where T : class, new()
    {
        private readonly EntityFrameworkDataModelContainer _db = new EntityFrameworkDataModelContainer();
        //private readonly DbContext _db = DbContextFactory.GetCurrentDbContext();

        public void IsUnique(string colName, string val)
        {
            //var t = _db.Set<T>();
        }

        public void Add(T model)
        {
            _db.Set<T>().Add(model);
        }

        public void Delete(int id)
        {
            var model = _db.Set<T>().Find(id);
            if (model != null)
            {
                _db.Set<T>().Remove(model);
            }
        }

        public void Edit(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
        }

        public bool SaveChanges()
        {
            return _db.SaveChanges() > 0;
        }


        public void Update(T entity, IEnumerable<Expression<Func<T, object>>> properties)
        {
            _db.Set<T>().Attach(entity);

            foreach (var property in properties)
            {
                _db.Entry(entity).Property(((MemberExpression)property.Body).Member.Name).IsModified = true;
            }

        }


        public IQueryable<T> GetEntitiesByKey(Expression<Func<T, bool>> whereLambda)
        {
            return _db.Set<T>().Where(whereLambda).AsQueryable();
        }

        public IQueryable<T> GetAllEntities()
        {
            return _db.Set<T>().AsQueryable();
        }

        public T GetEntityById(int id)
        {
            return _db.Set<T>().Find(id);
        }

    }
}
