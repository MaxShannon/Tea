using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using DalFactory;
using IDal;
using Model.ReturnMessageModel;

namespace Bll
{
    public abstract class BaseService<T> where T : class, new()
    {
        public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public IBaseDal<T> CurrentDal { get; set; }

        protected BaseService()
        {
            SetCurrentDal();
        }

        public abstract void SetCurrentDal();

        public virtual ReturnMessageModel Add(T model)
        {
            var returnMessageModel = new ReturnMessageModel();
            CurrentDal.Add(model);
            if (CurrentDal.SaveChanges())
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "添加成功";
                DbSession.SaveChanges();
            }
            else
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "添加失败";
            }
            return returnMessageModel;
        }

        public virtual ReturnMessageModel Delete(int id)
        {
            var returnMessageModel = new ReturnMessageModel();
            CurrentDal.Delete(id);
            if (CurrentDal.SaveChanges())
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "删除成功";
                DbSession.SaveChanges();
            }
            else
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "删除失败";
            }
            return returnMessageModel;
        }

        public virtual ReturnMessageModel Edit(T model)
        {
            var returnMessageModel = new ReturnMessageModel();
            CurrentDal.Edit(model);
            if (CurrentDal.SaveChanges())
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "修改成功";
                DbSession.SaveChanges();
            }
            else
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "修改失败";
            }
            return returnMessageModel;
        }

        public IQueryable<T> GetEntitiesByKey(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.GetEntitiesByKey(whereLambda);
        }

        public IQueryable<T> GetAllEntities()
        {
            return CurrentDal.GetAllEntities();
        }

        public T GetEntityById(int id)
        {
            return CurrentDal.GetEntityById(id);
        }

        public string GetNameById(int id)
        {
            return CurrentDal.GetNameById(id);
        }
    }
}