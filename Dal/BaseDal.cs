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
        //private readonly EntityFrameworkDataModelContainer _db = new EntityFrameworkDataModelContainer();
        private readonly DbContext _db = DbContextFactory.GetCurrentDbContext();

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

        public IQueryable<T> GetPageEntities<TO>(int pageSize, int pageIndex, out int total,
            Expression<Func<T, bool>> whereLambda, Expression<Func<T, TO>> orderByLambda, bool isAsc)
        {
            total = _db.Set<T>().Where(whereLambda).Count();
            return isAsc ? _db.Set<T>().Where(whereLambda).OrderBy(orderByLambda).Skip(pageIndex).Take(pageIndex).AsQueryable() : _db.Set<T>().Where(whereLambda).OrderByDescending(orderByLambda).Skip(pageIndex).Take(pageIndex).AsQueryable();

        }

        public IQueryable<T> GetAllEntities()
        {
            return _db.Set<T>().AsQueryable();
        }

        public T GetEntityById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public string GetNameById(int id)
        {
            //typeof(T).GetProperty().get
            return _db.Set<T>().Find(id)?.ToString();
        }

    }
}
