using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Model.DbQueryModel;
using Newtonsoft.Json;

namespace AquamanRoyalTea.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }


        private readonly UserInfoService _userInfoService = new UserInfoService();

        #region 登录
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserInfoViewModel model)
        {
            var json = _userInfoService.Login(model.UserName, model.Password);
            return Json(json);
        }
        #endregion

        private static object StrToJson(string str)
        {
            return JsonConvert.DeserializeObject(str);
        }
    }
}