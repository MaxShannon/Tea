using System;
using System.Linq;
using System.Linq.Expressions;
using Model.ReturnMessageModel;

namespace IBll
{
    public interface IBaseService<T> where T : class, new()
    {
        ReturnMessageModel Add(T model);

        ReturnMessageModel Delete(int id);

        ReturnMessageModel Edit(T model);

        IQueryable<T> GetEntitiesByKey(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> GetAllEntities();

        T GetEntityById(int id);
    }
}