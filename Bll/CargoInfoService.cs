using System;
using DalFactory;
using IBll;
using IDal;
using Model;
using Model.DbQueryModel;
using Model.ReturnMessageModel;

namespace Bll
{
    public class CargoInfoService : BaseService<CargoInfo>, ICargoInfoService
    {
        private ICargoLogInfoService CargoLogInfoService { get; set; }

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CargoInfoDal;
        }

        public CargoInfoService()
        {
            CargoLogInfoService = new CargoLogInfoService();
        }

    }
}