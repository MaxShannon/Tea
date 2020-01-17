using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;
using System.Linq;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class SupplyInfoController : BaseController<SupplyInfo>
    {

        public IServiceSession ServiceSession => ServiceSessionFactory.GetCurrentServiceSession();

        public override void SetCurrentService()
        {
            CurrentService = ServiceSession.SupplyInfoService;
            CategoryInfoService = ServiceSession.CategoryInfoService;
        }

        public ICategoryInfoService CategoryInfoService { get; set; }

        #region 展示列表
        public ActionResult Index()
        {
            var entities = CurrentService.GetAllEntities().OrderByDescending(m => m.Id).ToList();
            var model = ModelHelper<SupplyInfo, SupplyInfoViewModel>.EntitiesToModels(entities);
            return View(model);
        }
        #endregion

        #region 添加
        public ActionResult Create()
        {
            ViewBag.SupplyName = new SelectList(CategoryInfoService.GetAllEntities(), "Id", "SupplyName", 1);
            return View();
        }
        #endregion

        #region 修改
        public ActionResult Edit(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<SupplyInfo, SupplyInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 删除
        public ActionResult Delete(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<SupplyInfo, SupplyInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 添加品种
        public ActionResult AddCategory(int id)
        {
            var entity = CurrentService.GetEntityById(id);
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory()
        {
            //var entity = CurrentService.GetEntityById(id);
            return View();
        }
        #endregion

    }
}