using IBll;
using IDal;
using Model;
using Model.DbQueryModel;
using Model.ReturnMessageModel;

namespace Bll
{
    public class CargoLogInfoService : BaseService<CargoLogInfo>, ICargoLogInfoService
    {

        public ICargoInfoDal CargoInfoDal { get; set; }

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CargoLogInfoDal;
            CargoInfoDal = DbSession.CargoInfoDal;
        }

        public override ReturnMessageModel Add(CargoLogInfo model)
        {
            var returnMessageModel = new ReturnMessageModel();
            CurrentDal.Add(model);
            var cargo = CargoInfoDal.GetEntityById(model.CargoInfoId);
            if (model.IsIncome == true)
            {
                cargo.CargoCount += model.ChangeCount;
            }
            else
            {
                cargo.CargoCount -= model.ChangeCount;
            }
            CargoInfoDal.Edit(cargo);
            //CargoInfoDal.SaveChanges();
            //CurrentDal.SaveChanges();

            if (cargo.CargoCount > 0 && DbSession.SaveChanges() > 0)  // 必须分别提交？
            {
                //DbSession.SaveChanges();
                //CargoInfoDal.SaveChanges();
                //
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
    }
}