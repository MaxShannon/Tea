using DalFactory;
using IBll;
using Model;
using Model.DbQueryModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CargoLogInfoController : BaseController<CargoLogInfo>
    {

        public IServiceSession ServiceSession => ServiceSessionFactory.GetCurrentServiceSession();

        public ICargoLogInfoService CargoLogInfoService { get; set; }
        public ICargoInfoService CargoInfoService { get; set; }
        public IProjectInfoService ProjectInfoService { get; set; }

        public override void SetCurrentService()
        {
            CurrentService = ServiceSession.CargoLogInfoService;
            CargoInfoService = ServiceSession.CargoInfoService;
            CargoLogInfoService = ServiceSession.CargoLogInfoService;
            ProjectInfoService = ServiceSession.ProjectInfoService;
        }

        public ActionResult Index()
        {
            var entities = CurrentService.GetAllEntities().OrderByDescending(m => m.Id).ToList();
            var model = ModelHelper<CargoLogInfo, CargoLogInfoViewModel>.EntitiesToModels(entities);
            return View(model);
        }

        #region 添加
        public ActionResult Create(int cargoId, CargoInOutState cargoInOutState)
        {
            var model = new CargoLogInfoViewModel
            {
                CargoInfoId = cargoId,
                IsIncome = cargoInOutState == CargoInOutState.In,
                CargoInfoName = CargoInfoService.GetEntityById(cargoId).CargoName,
                Time = DateTime.Now
            };
            
            ViewBag.ProjectName = new SelectList(ProjectInfoService.GetAllEntities(), "Id", "ProjectName", 1);
            return View(model);
        }

        [HttpPost]
        public override ActionResult Create(CargoLogInfo cargoLogInfo)
        {
            var returnMessageModel = CurrentService.Add(cargoLogInfo);
            return Redirect(Url.Action("Index", "CargoInfo"));
        }
        #endregion

        #region 修改
        public ActionResult Edit(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CargoLogInfo, CargoLogInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion

        #region 删除
        public ActionResult Delete(int id)
        {
            //ViewBag.UserPrivilegesId = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
            var entity = CurrentService.GetEntityById(id);
            var model = ModelHelper<CargoLogInfo, CargoLogInfoViewModel>.EntityToModel(entity);
            return View(model);
        }
        #endregion
    }
}