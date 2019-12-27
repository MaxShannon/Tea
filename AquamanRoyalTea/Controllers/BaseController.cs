using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace AquamanRoyalTea.Controllers
{
    public class BaseController : Controller
    {
        public bool IsCheck = true;
        public UserInfo LoginUser { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterExecutingContext)
        {
            base.OnActionExecuting(filterExecutingContext);

            if (IsCheck)
            {
                if (filterExecutingContext.HttpContext.Session["loginUser"] == null)
                {
                    Session["loginUser"] = new UserInfo()
                    {
                        UserName = "max",
                        Password = "123"
                    };

                    //filterExecutingContext.HttpContext.Response.Redirect("Login/Index");
                }
                else
                {
                    LoginUser = filterExecutingContext.HttpContext.Session["loginUser"] as UserInfo;
                    ViewData["UserName"] = LoginUser == null ? null : LoginUser.UserName;
                }
            }

        }

    }
}