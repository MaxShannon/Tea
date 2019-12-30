using Bll;
using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;
using System.Linq;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CargoInfoController : BaseController<CargoInfo>
    {
        private readonly UserInfoService _userInfoService = new UserInfoService();

        public IServiceSession ServiceSession => ServiceSessionFactory.GetCurrentServiceSession();

        public override void SetCurrentService()
        {
            CurrentService = ServiceSession.CargoInfoService;
        }

        public ActionResult Index()
        {
            var entities = CurrentService.GetAllEntities().OrderByDescending(m => m.Id).ToList();
            var model = ModelHelper<CargoInfo, CargoInfoViewModel>.EntitiesToModels(entities);
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
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CargoInfo, CargoInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 删除
        public ActionResult Delete(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CargoInfo, CargoInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion
    }
}