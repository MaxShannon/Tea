using System;
using System.Collections.Generic;
using System.Text;
using Dal;
using IDal;

namespace DalFactory
{
    public class DbSession : IDbSession
    {
        public IUserInfoDal UserInfoDal => StaticDalFactory.GetUserInfoDal();

        public IUserPrivilegeInfoDal UserPrivilegeInfoDal => StaticDalFactory.GetUserPrivilegeInfoDal();

        public ISupplyInfoDal SupplyInfoDal => StaticDalFactory.GetSupplyInfoDal();

        public IProjectInfoDal ProjectInfoDal => StaticDalFactory.GetProjectInfoDal();

        public ICategoryInfoDal CategoryInfoDal => StaticDalFactory.GetCategoryInfoDal();

        public ICargoInfoDal CargoInfoDal => StaticDalFactory.GetCargoInfoDal();

        public ICargoLogInfoDal CargoLogInfoDal => StaticDalFactory.GetCargoLogInfoDal();

        public IOrderInfoDal OrderInfoDal => StaticDalFactory.GetOrderInfoDal();

     

        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }


    }
}
