using DalFactory;
using IBll;
using Model;

namespace Bll
{
    public class SupplyCategoryInfoService : BaseService<SupplyCategoryInfo>, ISupplyCategoryInfoService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.SupplyCategoryInfoDal;
        }
    }
}