using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBll;
using Model;
using Model.DbQueryModel;

namespace UI.Controllers
{
    public abstract class BaseController<T> : Controller where T : class, new()
    {
        public IBaseService<T> CurrentService { get; set; }

        public bool IsCheck = true;
        public UserInfo LoginUser { get; set; }

        public abstract void SetCurrentService();

        protected BaseController()
        {
            SetCurrentService();
        }

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
                    ViewData["UserName"] = LoginUser?.UserName;
                }
            }

        }

        [HttpPost]
        public virtual ActionResult Create(T model)
        {
            var returnMessageModel = CurrentService.Add(model);
            return Redirect(Url.Action("Index"));
            //return Json(returnMessageModel);
        }

        [HttpPost]
        public ActionResult Edit(T model)
        {
            var returnMessageModel = CurrentService.Edit(model);
            return Redirect(Url.Action("Index"));
            //return Json(returnMessageModel);
        }

        [HttpPost]
        public ActionResult Delete(UserInfo model)
        {
            var returnMessageModel = CurrentService.Delete(model.Id);
            return Redirect(Url.Action("Index"));
            //return Json(returnMessageModel);
        }
    }
}