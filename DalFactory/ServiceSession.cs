using IBll;

namespace DalFactory
{
    public class ServiceSession : IServiceSession
    {
        public IUserInfoService UserInfoService => StaticServiceFactory.GetUserInfoService();

        public IUserPrivilegeInfoService UserPrivilegeInfoService => StaticServiceFactory.GetUserPrivilegeInfoService();

        public ISupplyInfoService SupplyInfoService => StaticServiceFactory.GetSupplyInfoService();

        public IProjectInfoService ProjectInfoService => StaticServiceFactory.GetProjectInfoService();

        public ICategoryInfoService CategoryInfoService => StaticServiceFactory.GetCategoryInfoService();

        public ICargoInfoService CargoInfoService => StaticServiceFactory.GetCargoInfoService();

        public ICargoLogInfoService CargoLogInfoService => StaticServiceFactory.GetCargoLogInfoService();

        public ISupplyCategoryInfoService SupplyCategoryInfoService => StaticServiceFactory.GetSupplyCategoryInfoService();

        


    }
}