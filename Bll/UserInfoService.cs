using DalFactory;
using IBll;
using IDal;
using Model.DbQueryModel;
using Model.ReturnMessageModel;
using System.Linq;
using Model;

namespace Bll
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {

        //public IDbSession DbSession => DbSessionFactory.GetCurrentDbSession();

        public override void SetCurrentDal()
        {
            CurrentDal = DbSession.UserInfoDal;
        }

        #region 登陆
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>返回一个Json</returns>
        public ReturnMessageModel Login(string userName, string password)
        {
            var returnMessageModel = CheckPassword(userName, password);
            return returnMessageModel;
        }


        private ReturnMessageModel CheckPassword(string userName, string password)
        {
            var returnMessageModel = new ReturnMessageModel();
            var userList = CurrentDal.GetEntitiesByKey(m => m.UserName == userName).ToList();
            if (userList.Count == 0)
            {
                returnMessageModel.Code = ReturnMessageCode.Fail;
                returnMessageModel.Message = "用户名不存在";
            }
            else if (userList.Count > 1)
            {
                returnMessageModel.Code = ReturnMessageCode.SystemError;
                returnMessageModel.Message = "用户名太多";
            }
            else
            {
                if (userList[0].Password == password)
                {
                    returnMessageModel.Code = ReturnMessageCode.Success;
                    returnMessageModel.Message = "登陆成功";
                    //Session["loginUser"]  = 
                }
                else
                {
                    returnMessageModel.Code = ReturnMessageCode.Fail;
                    returnMessageModel.Message = "密码错误";
                }
            }

            return returnMessageModel;
        }



        #endregion

        #region MyRegion

        #endregion


    }
}
