using System;
using System.Collections.Generic;
using System.Text;
using DalFactory;
using IDal;

namespace Dal
{
    public class DbSession : IDbSession
    {
        public IUserInfoDal UserInfoDal
        {
            get { return StaticDalFactory.GetUserInfoDal(); }
        }

        public IOrderInfoDal OrderInfoDal
        {
            get { return StaticDalFactory.GetOrderInfoDal(); }
        }


        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }


    }
}
