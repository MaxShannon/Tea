using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model.ReturnMessageModel;

namespace IDal
{
    public interface IBaseDal<T> where T : class, new()
    {
        bool Add(T model);

        bool Delete(int id);

        bool Edit(T model);

        IQueryable<T> GetEntitiesByKey(Expression<Func<T, bool>> whereLambda);

        IQueryable<T> GetAllEntities();

        T GetEntityById(int id);

        //List<T> FindValueByKey(Expression<Func<T, bool>> whereLambda);
    }
}
