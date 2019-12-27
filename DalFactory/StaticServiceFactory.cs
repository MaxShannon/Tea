using System.Reflection;
using IBll;


namespace DalFactory
{
    public class StaticServiceFactory
    {
        public static string AssemblyName = System.Configuration.ConfigurationManager.AppSettings["ServiceAssemblyName"];

        public static IUserInfoService GetUserInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserInfoService") as IUserInfoService;
        }

        public static IUserPrivilegeInfoService GetUserPrivilegeInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserPrivilegeInfoService") as IUserPrivilegeInfoService;
        }

        public static ISupplyInfoService GetSupplyInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".SupplyInfoService") as ISupplyInfoService;
        }

        public static IProjectInfoService GetProjectInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".ProjectInfoService") as IProjectInfoService;
        }

        public static ICategoryInfoService GetCategoryInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CategoryInfoService") as ICategoryInfoService;
        }
        
        public static ICargoInfoService GetCargoInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CargoInfoService") as ICargoInfoService;
        }

        public static ICargoLogInfoService GetCargoLogInfoService()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CargoLogInfoService") as ICargoLogInfoService;
        }
    }
}