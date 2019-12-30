using DalFactory;
using IBll;
using IDal;
using Model;

namespace Bll
{
    public class CargoInfoService : BaseService<CargoInfo>, ICargoInfoService
    {
        public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CargoInfoDal;
        }


    }
}