using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IDal;

namespace DalFactory
{
    public class StaticDalFactory
    {
        public static string AssemblyName = System.Configuration.ConfigurationManager.AppSettings["DalAssemblyName"];

        public static IUserInfoDal GetUserInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserInfoDal") as IUserInfoDal;
        }

        public static IUserPrivilegeInfoDal GetUserPrivilegeInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".UserPrivilegeInfoDal") as IUserPrivilegeInfoDal;
        }

        public static ISupplyInfoDal GetSupplyInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".SupplyInfoDal") as ISupplyInfoDal;
        }

        public static IProjectInfoDal GetProjectInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".ProjectInfoDal") as IProjectInfoDal;
        }

        public static ICategoryInfoDal GetCategoryInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CategoryInfoDal") as ICategoryInfoDal;
        }
        
        public static ICargoInfoDal GetCargoInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CargoInfoDal") as ICargoInfoDal;
        }

        public static ICargoLogInfoDal GetCargoLogInfoDal()
        {
            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".CargoLogInfoDal") as ICargoLogInfoDal;
        }

        public static IOrderInfoDal GetOrderInfoDal()
        {
            //return new UserInfoDal(); 

            return Assembly.Load(AssemblyName).CreateInstance(AssemblyName + ".OrderInfoDal") as IOrderInfoDal;
        }
    }
}
