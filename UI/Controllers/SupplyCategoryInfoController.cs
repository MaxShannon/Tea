using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;

namespace UI.Controllers
{
    public class SupplyCategoryInfoController : BaseController<SupplyCategoryInfo>
    {

        public IServiceSession ServiceSession => ServiceSessionFactory.GetCurrentServiceSession();

        public override void SetCurrentService()
        {
            CurrentService = ServiceSession.SupplyCategoryInfoService;
            SupplyInfoService = ServiceSession.SupplyInfoService;
            CategoryInfoService = ServiceSession.CategoryInfoService;
        }

        public ISupplyInfoService SupplyInfoService { get; set; }
        public ICategoryInfoService CategoryInfoService { get; set; }



        public ActionResult Index(int id, SupplyOrCategory state)
        {
            if (state == SupplyOrCategory.Supply)
            {
                return Redirect(Url.Action("ShowCategoryInfos", "SupplyCategoryInfo", new { id }));
            }

            if (state == SupplyOrCategory.Category)
            {
                return Redirect(Url.Action("ShowSupplyInfos", "SupplyCategoryInfo", new { id }));
            }

            return null;
        }

        public ActionResult ShowCategoryInfos(int id)
        {
            var entities = CategoryInfoService.GetAllEntities().ToList();
            var model = ModelHelper<CategoryInfo, CategoryInfoViewModel>.EntitiesToModels(entities);
            ViewBag.SupplyInfoId = id;
            return View(model);
        }

        public ActionResult ShowSupplyInfos(int id)
        {
            var entities = SupplyInfoService.GetAllEntities().ToList();
            var model = ModelHelper<SupplyInfo, SupplyInfoViewModel>.EntitiesToModels(entities);
            ViewBag.CategoryInfoId = id;
            return View(model);
        }

        public ActionResult Create(SupplyCategoryInfoViewModel model)
        {
            SupplyInfoService.get
            return View();
            var returnMessageModel = CurrentService.Add(model);
            return Redirect(Url.Action("Index"));
            //return base.Create(model);
        }

    }
}