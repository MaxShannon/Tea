using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Bll;
using IBll;
using Model;

namespace UI.Controllers
{
    public class UserPrivilegeInfoController : BaseController<UserPrivileges>//, IBaseService<UserPrivileges>
    {
        private readonly UserInfoService _userInfoService = new UserInfoService();
        private readonly UserPrivilegeInfoService _userPrivilegeInfoService = new UserPrivilegeInfoService();

        public ActionResult Add(UserPrivileges model)
        {
            return View();
        }

        public ActionResult Delete(UserPrivileges model)
        {
            throw new NotImplementedException();
        }

     

        public ActionResult GetEntitiesByKey(Expression<Func<UserPrivileges, bool>> whereLambda)
        {//IQueryable<UserPrivileges>
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            return View();
        }

        public override void SetCurrentService()
        {
            throw new NotImplementedException();
        }

        #region 添加

        #endregion

    }
}