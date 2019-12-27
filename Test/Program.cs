using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.DbQueryModel;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var userInfo = new UserInfo()
            {
                Id = 10,
                UserName = "max",
                Password = "123"
            };
            List<UserInfo> userInfos = new List<UserInfo>()
            {
                new UserInfo(){ Id = 10,UserName = "max",Password = "123"},
                new UserInfo(){ Id = 10,UserName = "max",Password = "123"},
                new UserInfo(){ Id = 10,UserName = "max",Password = "123"},
                new UserInfo(){ Id = 10,UserName = "max",Password = "123"}
            };
            List<UserInfoViewModel> userViewModels = new List<UserInfoViewModel>();
            foreach (var item in userInfos)
            {
                userViewModels.Add(ModelHelper<UserInfo, UserInfoViewModel>.EntityToModel(item));
            }

            var tt = ModelHelper<UserInfo, UserInfoViewModel>.EntitiesToModels(userInfos);
        }
    }
}
