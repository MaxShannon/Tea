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
        public IBaseDal<T> CurrentDal { get; set; }

        protected BaseService()
        {
            SetCurrentDal();
        }

        public abstract void SetCurrentDal();



        public ReturnMessageModel Add(T model)
        {
            var returnMessageModel = new ReturnMessageModel();
            if (CurrentDal.Add(model))
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "添加成功";
                //DbSession.SaveChanges();
            }
            else
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "添加失败";
            }
            return returnMessageModel;
        }

        public ReturnMessageModel Delete(int id)
        {
            var returnMessageModel = new ReturnMessageModel();
            if (CurrentDal.Delete(id))
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "删除成功";
            }
            else
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "删除失败";
            }
            return returnMessageModel;
        }

        public ReturnMessageModel Edit(T model)
        {
            var returnMessageModel = new ReturnMessageModel();
            if (CurrentDal.Edit(model))
            {
                returnMessageModel.Code = ReturnMessageCode.Success;
                returnMessageModel.Message = "修改成功";
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


    }
}