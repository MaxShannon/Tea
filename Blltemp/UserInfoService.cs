using System;
using System.Collections.Generic;
using System.Text;
using Dal;
using IDal;
using Model;

namespace Bll
{
    public class UserInfoService
    {
        readonly IDbSession dbSession = new DbSession();

        //IUserInfoDal userInfoDal = new UserInfoDal();

        public UserInfo Add(UserInfo userInfo)
        {
            dbSession.UserInfoDal.Add(userInfo);
            dbSession.SaveChanges();
            //return userInfoDal.Add(userInfo);
            return null;
        }
    }
}
