using DalFactory;
using IBll;
using IDal;
using Model;

namespace Bll
{
    public class CategoryInfoService : BaseService<CategoryInfo>, ICategoryInfoService
    {

        public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CategoryInfoDal;
        }


    }
}