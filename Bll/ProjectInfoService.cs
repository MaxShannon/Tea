using DalFactory;
using IBll;
using IDal;
using Model;

namespace Bll
{
    public class ProjectInfoService : BaseService<ProjectInfo>, IProjectInfoService
    {
        //public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ProjectInfoDal;
        }
    }
}