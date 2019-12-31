using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using DalFactory;
using IBll;
using IDal;
using Model;
using Model.DbQueryModel;

namespace Bll
{
    public class SupplyInfoService : BaseService<SupplyInfo>, ISupplyInfoService
    {

        //public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession(); 


        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.SupplyInfoDal;
        }
    }
}
