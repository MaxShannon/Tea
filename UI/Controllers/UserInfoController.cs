using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bll;
using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;
using Model.ReturnMessageModel;
using Newtonsoft.Json;

namespace UI.Controllers
{
    public class UserInfoController : BaseController<UserInfo>
    {

        public IServiceSession SessionSession => ServiceSessionFactory.GetCurrentServiceSession();
        private readonly UserInfoService _userInfoService = new UserInfoService();
        private readonly UserPrivilegeInfoService _userPrivilegeInfoService = new UserPrivilegeInfoService();

        public override void SetCurrentService()
        {
            CurrentService = SessionSession.UserInfoService;
        }

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

        #region 展示列表
        public ActionResult Index()
        {
            var entities = _userInfoService.GetAllEntities().OrderByDescending(m => m.Id).ToList();
            var model = ModelHelper<UserInfo, UserInfoViewModel>.EntitiesToModels(entities);
            return View(model);
        }
        #endregion

        #region 添加
        public ActionResult Create()
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            return View();
        }
        #endregion

        #region 修改
        public ActionResult Edit(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = _userInfoService.GetEntityById(id);
            var model = ModelHelper<UserInfo, UserInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 删除
        public ActionResult Delete(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = _userInfoService.GetEntityById(id);
            var model = ModelHelper<UserInfo, UserInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion


        private static object StrToJson(string str)
        {
            return JsonConvert.DeserializeObject(str);
        }

    
    }
}