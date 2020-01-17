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
            var cargoLogInfo = new CargoLogInfo()
            {
                Id = 10,
                CargoInfoId = 1,
                TakenName = "TakenName",
            };
            //List<CargoInfo> userInfos = new List<CargoInfo>()
            //{
            //    new CargoInfo(){ Id = 10, = "max",Password = "123"},
               
            //};
            //List<UserInfoViewModel> userViewModels = new List<UserInfoViewModel>();
            //foreach (var item in userInfos)
            //{
            //    userViewModels.Add(ModelHelper<UserInfo, UserInfoViewModel>.EntityToModel(item));
            //}

            //var tt = ModelHelper<UserInfo, UserInfoViewModel>.EntitiesToModels(userInfos);
            var t = ModelHelper<CargoLogInfo, CargoLogInfoViewModel>.EntityToModel(cargoLogInfo);
        }
    }
}
