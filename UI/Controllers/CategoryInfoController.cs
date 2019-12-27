using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;

namespace UI.Controllers
{
    public class CategoryInfoController : BaseController<CategoryInfo>
    {
        public IServiceSession ServiceSession => ServiceSessionFactory.GetCurrentServiceSession();

        public override void SetCurrentService()
        {
            CurrentService = ServiceSession.CategoryInfoService;
            SupplyInfoService = ServiceSession.SupplyInfoService;
        }

        public ISupplyInfoService SupplyInfoService { get; set; }

        public ActionResult Index()
        {
            var entities = CurrentService.GetAllEntities().OrderByDescending(m => m.Id).ToList();
            var model = ModelHelper<CategoryInfo, CategoryInfoViewModel>.EntitiesToModels(entities);
            return View(model);
        }

        #region 添加
        public ActionResult Create()
        {
            return View();
        }
        #endregion

        #region 修改
        public ActionResult Edit(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.CategoryInfo, "Id", "CategoryName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CategoryInfo, CategoryInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 删除
        public ActionResult Delete(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.CategoryInfo, "Id", "CategoryName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CategoryInfo, CategoryInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion


    }
}