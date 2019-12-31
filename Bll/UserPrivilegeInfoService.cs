using DalFactory;
using IBll;
using IDal;
using Model;

namespace Bll
{
    public class UserPrivilegeInfoService : BaseService<UserPrivileges>, IUserPrivilegeInfoService
    {

        //public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserPrivilegeInfoDal;
        }
    }
}