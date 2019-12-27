using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Model;
using Model.DbQueryModel;

namespace UI.Controllers
{
    public class CargoInfoController : BaseController<CargoInfo>
    {
        private readonly UserInfoService _userInfoService = new UserInfoService();

        #region 展示商品
        public ActionResult Index()
        {
            ViewBag.PowerInfoId = LoginUser.UserPrivilegesId;
            return View();
        }

        [HttpPost]
        public ActionResult Index(CargoInfoViewModel cargoInfoViewModel, int limit, int offset)
        {
            //_userInfoService.
            //var temp = (from cargoInfo in _db.CargoInfo select new { cargoInfo.Id, cargoInfo.CargoName, cargoInfo.Amount, cargoInfo.CargoCount, cargoInfo.Unit, cargoInfo.DelFlag, cargoInfo.Specifications, cargoInfo.Type, cargoInfo.Area, cargoInfo.CanDel }).Where(c => c.DelFlag == false);

            //if (cargoInfoViewModel.Id != 0)
            //{
            //    temp = temp.Where(c => c.Id == cargoInfoViewModel.Id);
            //}
            //if (!cargoInfoViewModel.CargoName.IsEmpty())
            //{
            //    //temp = temp.Where(c => c.CargoName.Contains(cargoInfoViewModel.CargoName)); // 模糊
            //    temp = temp.Where(c => c.CargoName == cargoInfoViewModel.CargoName);
            //}
            //var list = temp.OrderByDescending(c => c.Id).ToList();
            //return Json(new { total = list.Count, rows = list.Skip(offset).Take(limit).ToList() });
            return Json("");
        }
        #endregion

        #region 废弃
        public ActionResult Storage()
        {
            return View();
        }
        #endregion

        #region 新建商品
        public ActionResult Create()
        {
            if (LoginUser.UserPrivilegesId != 1 && LoginUser.UserPrivilegesId != 2)
            {
                return Redirect("login/logoff");
            }
            //ViewBag.Power = new SelectList(_db.PowerInfo, "Id", "PowerName", 1);
            return View();
        }

        [HttpPost]
        public ActionResult Create(CargoInfoViewModel cargoInfoViewModel)
        {
            //if (cargoInfoViewModel.CargoName.Replace(" ", "").Replace("  ", "").IsEmpty())
            //{
            //    return Json(new { success = "fail", message = "请输入商品名" });
            //}
            //var cargoInfo = new CargoInfo()
            //{
            //    CargoName = cargoInfoViewModel.CargoName.Replace(" ", "").Replace("  ", ""),
            //    LastCargoName = cargoInfoViewModel.CargoName,
            //    Unit = cargoInfoViewModel.Unit,
            //    Amount = cargoInfoViewModel.Amount,
            //    Specifications = cargoInfoViewModel.Specifications,
            //    Type = cargoInfoViewModel.Type,
            //    Area = cargoInfoViewModel.Area,
            //    CanDel = true,
            //};
            //var cargo = _db.CargoInfo.FirstOrDefault(c => c.CargoName == cargoInfo.CargoName && c.Unit == cargoInfo.Unit && c.Specifications == cargoInfo.Specifications && c.Type == cargoInfo.Type && c.Area == cargoInfo.Area);
            //if (cargo != null)
            //{
            //    return Json(new { success = "fail", message = "这个商品已经存在" });
            //}
            ////var temp = _db.CargoInfo.Add(userInfo);
            //_db.CargoInfo.Add(cargoInfo);
            //return _db.SaveChanges() > 0 ? Json(new { success = "success", message = "添加成功" }) : Json(new { success = "fail", message = "" });
            return Json("");
        }
        #endregion

        #region 明细
        public ActionResult Details(int id)
        {
            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        public ActionResult Details(int? id, int limit, int offset)
        {
          

            //var list = (from cargoLogInfo in _db.CargoLogInfo
            //            join cargoInfo in _db.CargoInfo on cargoLogInfo.CargoInfoId equals cargoInfo.Id
            //            join userInfo in _db.UserInfo on cargoLogInfo.UserId equals userInfo.Id
            //            join supplyInfo in _db.SupplyInfo on cargoLogInfo.SupplyId equals supplyInfo.Id
            //            join projectInfo in _db.ProjectInfo on (int)cargoLogInfo.ProjectId equals projectInfo.Id
            //                into projectInfoJoin
            //            from projectInfo in projectInfoJoin.DefaultIfEmpty()
            //            where cargoInfo.Id == id
            //            select new
            //            {
            //                CargoLogId = cargoLogInfo.Id,
            //                cargoLogInfo.IsIncome,
            //                cargoLogInfo.ChangeCount,
            //                cargoLogInfo.Time,
            //                cargoInfo.CargoName,
            //                projectInfo.ProjectName,
            //                userInfo.RealName,
            //                cargoLogInfo.Desc,
            //                cargoLogInfo.TakenName,
            //                SupplyName = supplyInfo.Name
            //            }).ToList();



            ////var tt = _db.CargoLogInfo.Join(_db.CargoInfo, cargoLog => cargoLog.CargoInfoId, cargo => cargo.Id, (cargoLog, cargo) => new { ProjectId = cargoLog.ProjectId, CargoLogId = cargoLog.Id, cargoLog.IsIncome, cargoLog.ChangeCount, cargoLog.Time, cargo.CargoName }).GroupJoin(_db.ProjectInfo, c => c.ProjectId, pro => pro.Id, (c, pro) => new { c.CargoLogId, c.IsIncome, c.ChangeCount, c.Time, c.CargoName, pro }).Select(o => new { o.CargoName, o.CargoLogId, o.ChangeCount, o.IsIncome, o.Time, o.pro });

            //return Json(new { total = list.Count, rows = list.OrderByDescending(c => c.Time).Skip(offset).Take(limit).ToList() });
            return Json("");
        }
        #endregion

        #region 修改商品信息
        public ActionResult Edit(int id)
        {
            //var cargo = _db.CargoInfo.Find(id);
            //if (cargo == null)
            //{
            //    return Redirect("index");
            //}
            //ViewData.Model = new CargoInfoViewModel()
            //{
            //    Id = cargo.Id,
            //    CargoName = cargo.CargoName,
            //    Unit = cargo.Unit,
            //    Amount = cargo.Amount,
            //    Specifications = cargo.Specifications,
            //    Type = cargo.Type,
            //    Area = cargo.Area
            //};
            return View();
        }

        #endregion

        #region 删除商品
        public ActionResult Delete(int id)
        {
            //var cargo = _db.CargoInfo.Find(id);
            //if (cargo == null)
            //{
            //    return Redirect("index");
            //}
            //var model = new CargoInfoViewModel()
            //{
            //    Id = cargo.Id,
            //    CargoName = cargo.CargoName,
            //    Unit = cargo.Unit,
            //    Amount = cargo.Amount,
            //    Specifications = cargo.Specifications,
            //    Area = cargo.Area
            //};
            return View();
        }

        [HttpPost]
        public ActionResult Delete(CargoInfo cargoInfo)
        {
            //var cargo = _db.CargoInfo.Find(cargoInfo.Id);
            //_db.CargoInfo.Remove(cargo);
            //return _db.SaveChanges() > 0
            //    ? Json(new { success = "success", message = "删除成功" })
            //    : Json(new { success = "fail", message = "删除失败" });
            return Json(new { success = "fail", message = "删除失败" });
        }

        public override void SetCurrentService()
        {
            throw new NotImplementedException();
        }
        #endregion

        //#region 进货
        //public ActionResult StorageIncoming()
        //{
        //    ViewBag.PowerInfoId = LoginUser.PowerInfoId;
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult StorageIncoming(CargoInfoViewModel cargoInfoViewModel, int limit, int offset)
        //{
        //    var temp = (from a in _db.CargoLogInfo
        //                join b in _db.CargoInfo on new { Id = a.CargoInfoId } equals new { b.Id }
        //                join c in _db.UserInfo on a.UserId equals c.Id
        //                join d in _db.SupplyInfo on a.SupplyId equals d.Id
        //                join projectInfo in _db.ProjectInfo on new { Id = (int)a.ProjectId } equals new
        //                { projectInfo.Id } into projectInfoJoin
        //                from projectInfo in projectInfoJoin.DefaultIfEmpty()
        //                where
        //                    a.IsIncome == true
        //                select new
        //                {
        //                    CargoLogId = a.Id,
        //                    b.CargoName,
        //                    a.ChangeCount,
        //                    a.Time,
        //                    b.Unit,
        //                    b.Specifications,
        //                    b.Type,
        //                    c.UserName,
        //                    b.Amount,
        //                    SumAmount = b.Amount * a.ChangeCount,
        //                    a.IsIncome,
        //                    projectInfo.ProjectName,
        //                    a.Desc,
        //                    a.TakenName,
        //                    SupplyName = d.Name
        //                });
        //    if (cargoInfoViewModel.CargoName != null)
        //    {
        //        temp = temp.Where(c => c.CargoName.Contains(cargoInfoViewModel.CargoName));
        //    }
        //    if (cargoInfoViewModel.CargoName != null)
        //    {
        //        temp = temp.Where(c => c.CargoName.Contains(cargoInfoViewModel.CargoName));
        //    }

        //    if (cargoInfoViewModel.TimeEnd == DateTime.MinValue)
        //    {
        //        cargoInfoViewModel.TimeEnd = DateTime.MaxValue;
        //    }
        //    temp = temp.Where(c => cargoInfoViewModel.TimeStart <= c.Time && c.Time < cargoInfoViewModel.TimeEnd);

        //    var list = temp.OrderByDescending(m => m.CargoLogId).ToList();
        //    return Json(new { total = list.Count(), rows = list.Skip(offset).Take(limit).ToList() });
        //}

        //#region 新增入库
        //public ActionResult StorageIncomingCreate(int? id)
        //{
        //    var cargo = _db.CargoInfo.Find(id);
        //    if (cargo == null)
        //    {
        //        return Redirect("index");
        //    }
        //    var model = new CargoInfoViewModel() { Id = cargo.Id, CargoName = cargo.CargoName, Unit = cargo.Unit, Specifications = cargo.Specifications, Type = cargo.Type };
        //    ViewBag.ProjectName = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
        //    ViewBag.SupplyName = new SelectList(_db.SupplyInfo, "Id", "Name", 1);
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult StorageIncomingCreate(CargoInfoViewModel cargoInfoViewModel)
        //{
        //    if (cargoInfoViewModel.ChangeCount < 0)
        //    {
        //        return Json(new { success = "fail", message = "入库商品不能为负数" });
        //    }
        //    if (cargoInfoViewModel.ChangeCount == 0)
        //    {
        //        return Json(new { success = "fail", message = "入库商品不能为0" });
        //    }
        //    if (Session["LoginUser"] == null)
        //    {
        //        return Json(new { success = "fail", message = "请重新登陆" });
        //    }

        //    using (var tran = _db.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            var cargo = _db.CargoInfo.FirstOrDefault(c => c.Id == cargoInfoViewModel.Id);
        //            if (cargo != null)
        //            {
        //                cargo.CargoCount += cargoInfoViewModel.ChangeCount;
        //                cargo.CanDel = false;
        //                _db.Entry(cargo).Property("CargoCount").IsModified = true;

        //                if (_db.SaveChanges() > 0 && Session["LoginUser"] is UserInfo user)
        //                {
        //                    _db.CargoLogInfo.Add(new CargoLogInfo() { CargoInfoId = cargo.Id, ChangeCount = cargoInfoViewModel.ChangeCount, IsIncome = true, Time = DateTime.Now, ProjectId = cargoInfoViewModel.ProjectId, UserId = user.Id, Desc = cargoInfoViewModel.Desc, TakenName = cargoInfoViewModel.TakenName, SupplyId = cargoInfoViewModel.SupplyId });

        //                    var project = _db.ProjectInfo.Find(cargoInfoViewModel.ProjectId);
        //                    project.CanDel = false; ////////// 空项目
        //                    _db.Entry(project).Property(m => m.CanDel).IsModified = true;

        //                    var supply = _db.SupplyInfo.Find(cargoInfoViewModel.SupplyId);
        //                    supply.CanDel = false;
        //                    _db.Entry(supply).Property(m => m.CanDel).IsModified = true;

        //                    if (_db.SaveChanges() > 0)
        //                    {
        //                        tran.Commit();
        //                        return Json(new { success = "success", message = "添加商品成功" });
        //                    }
        //                    else
        //                    {
        //                        tran.Rollback();
        //                        return Json(new { success = "fail", message = "添加商品失败" });
        //                    }
        //                }
        //                return Json(new { success = "fail", message = "添加商品失败" });
        //            }
        //            return Json(new { success = "fail", message = "当前货物不存在" });
        //        }
        //        catch (Exception e)
        //        {
        //            tran.Rollback();
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }



        //}
        //#endregion

        //#endregion

        //#region 出货
        //public ActionResult StorageShipping()
        //{
        //    ViewBag.PowerInfoId = LoginUser.PowerInfoId;
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult StorageShipping(CargoInfoViewModel cargoInfoViewModel, int limit, int offset)
        //{
        //    var temp = (from t0 in _db.CargoLogInfo
        //                join t1 in _db.CargoInfo on new { t0.CargoInfoId } equals new { CargoInfoId = t1.Id }
        //                join t2 in _db.UserInfo on t0.UserId equals t2.Id
        //                join d in _db.SupplyInfo on t0.SupplyId equals d.Id
        //                join projectInfo in _db.ProjectInfo on new { Id = (int)t0.ProjectId } equals new
        //                { projectInfo.Id } into projectInfoJoin
        //                from projectInfo in projectInfoJoin.DefaultIfEmpty()
        //                where
        //                    t0.IsIncome == false
        //                select new
        //                {
        //                    CargoLogId = t0.Id,
        //                    t1.CargoName,
        //                    t0.ChangeCount,
        //                    t0.Time,
        //                    t1.Unit,
        //                    projectInfo.ProjectName,
        //                    t1.Specifications,
        //                    t1.Type,
        //                    t0.Desc,
        //                    t2.UserName,
        //                    t0.TakenName,
        //                    t1.Amount,
        //                    SumAmount = t1.Amount * (decimal)t0.ChangeCount,
        //                    t0.IsIncome,
        //                    SupplyName = d.Name
        //                });
        //    if (cargoInfoViewModel.CargoName != null)
        //    {
        //        temp = temp.Where(c => c.CargoName.Contains(cargoInfoViewModel.CargoName));
        //    }

        //    if (cargoInfoViewModel.TimeEnd == DateTime.MinValue)
        //    {
        //        cargoInfoViewModel.TimeEnd = DateTime.MaxValue;
        //    }
        //    temp = temp.Where(c => cargoInfoViewModel.TimeStart <= c.Time && c.Time < cargoInfoViewModel.TimeEnd);

        //    var list = temp.ToList();
        //    return Json(new { total = list.Count, rows = list.OrderByDescending(m => m.Time).Skip(offset).Take(limit).ToList() });
        //}

        //#region 新增出库
        //public ActionResult StorageShippingCreate(int? id)
        //{
        //    var cargo = _db.CargoInfo.Find(id);
        //    if (cargo == null)
        //    {
        //        return Redirect("index");
        //    }
        //    ViewData.Model = new CargoInfoViewModel() { Id = cargo.Id, CargoName = cargo.CargoName, Unit = cargo.Unit, Specifications = cargo.Specifications, Type = cargo.Type };
        //    ViewBag.ProjectName = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult StorageShippingCreate(CargoInfoViewModel cargoInfoViewModel)
        //{
        //    if (cargoInfoViewModel.ChangeCount < 0)
        //    {
        //        return Json(new { success = "fail", message = "出库商品不能为负数" });
        //    }
        //    if (cargoInfoViewModel.ChangeCount == 0)
        //    {
        //        return Json(new { success = "fail", message = "出库商品不能为0" });
        //    }
        //    if (Session["LoginUser"] == null)
        //    {
        //        return Json(new { success = "fail", message = "请重新登陆" });
        //    }

        //    using (var tran = _db.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            var cargo = _db.CargoInfo.FirstOrDefault(c => c.Id == cargoInfoViewModel.Id);
        //            if (cargo != null)
        //            {
        //                cargo.CargoCount -= cargoInfoViewModel.ChangeCount;
        //                if (cargo.CargoCount < 0)
        //                {
        //                    return Json(new { success = "fail", message = "当前没有呢么多货物" });
        //                }
        //                _db.Entry(cargo).Property("CargoCount").IsModified = true;

        //                if (_db.SaveChanges() > 0 && Session["LoginUser"] is UserInfo user)
        //                {
        //                    _db.CargoLogInfo.Add(new CargoLogInfo() { CargoInfoId = cargo.Id, ChangeCount = cargoInfoViewModel.ChangeCount, IsIncome = false, Time = DateTime.Now, ProjectId = cargoInfoViewModel.ProjectId, UserId = user.Id, Desc = cargoInfoViewModel.Desc, TakenName = cargoInfoViewModel.TakenName });

        //                    if (_db.SaveChanges() > 0)
        //                    {
        //                        tran.Commit();
        //                        return Json(new { success = "success", message = "添加商品出库成功" });
        //                    }
        //                    else
        //                    {
        //                        tran.Rollback();
        //                        return Json(new { success = "fail", message = "添加商品出库失败" });
        //                    }

        //                }
        //                return Json(new { success = "fail", message = "添加商品出库失败" });
        //            }
        //            return Json(new { success = "fail", message = "当前货物不存在" });
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }



        //}
        //#endregion

        //#region 修改出库
        //public ActionResult EditStorageShipping(int cargoLogId)
        //{
        //    var cargoLog = _db.CargoLogInfo.Find(cargoLogId);
        //    if (cargoLog == null)
        //    {
        //        return Redirect("StorageShipping");
        //    }
        //    var cargo = _db.CargoInfo.Find(cargoLog.CargoInfoId);
        //    if (cargo == null)
        //    {
        //        return Redirect("index");
        //    }
        //    ViewData.Model = new CargoInfoViewModel() { Id = cargo.Id, CargoName = cargo.CargoName, Unit = cargo.Unit, Specifications = cargo.Specifications, Type = cargo.Type, CargoLogId = cargoLog.Id, TakenName = cargoLog.TakenName, Time = cargoLog.Time, Desc = cargoLog.Desc, ProjectId = cargoLog.ProjectId };
        //    ViewBag.ProjectName = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult EditStorageShipping(CargoInfoViewModel cargoLogInfo) ///////////////////////////
        //{
        //    var cargoLog = _db.CargoLogInfo.Find(cargoLogInfo.CargoLogId);
        //    if (cargoLog == null)
        //    {
        //        return Json(new { success = "fail", message = "修改失败，没有当前记录" });
        //    }
        //    var cargo = _db.CargoInfo.Find(cargoLog.CargoInfoId);
        //    if (cargo == null)
        //    {
        //        return Json(new { success = "fail", message = "修改失败，没有当前的商品" });
        //    }

        //    cargoLog.TakenName = cargoLogInfo.TakenName;
        //    cargoLog.Time = DateTime.Now;
        //    cargoLog.ProjectId = cargoLogInfo.ProjectId;
        //    cargoLog.Desc = cargoLogInfo.Desc;
        //    _db.CargoLogInfo.Attach(cargoLog);
        //    _db.Entry(cargoLog).Property(c => c.TakenName).IsModified = true;
        //    _db.Entry(cargoLog).Property(c => c.Time).IsModified = true;
        //    _db.Entry(cargoLog).Property(c => c.ProjectId).IsModified = true;
        //    _db.Entry(cargoLog).Property(c => c.Desc).IsModified = true;
        //    return _db.SaveChanges() > 0
        //        ? Json(new { success = "success", message = "修改成功" })
        //        : Json(new { success = "fail", message = "修改失败" });
        //}
        //#endregion
        //#endregion

        //#region 还原

        //public ActionResult Back(int cargoLogId)
        //{
        //    var cargoLog = _db.CargoLogInfo.Find(cargoLogId);
        //    if (cargoLog == null)
        //    {
        //        return Redirect("index");
        //    }
        //    var cargoLogViewModel = new CargoInfoViewModel()
        //    {
        //        CargoLogId = cargoLog.Id,
        //        ChangeCount = cargoLog.ChangeCount,
        //        CargoName = _db.CargoInfo.Find(cargoLog.CargoInfoId)?.CargoName,
        //        IsIncome = cargoLog.IsIncome == null ? true : (bool)cargoLog.IsIncome
        //    };
        //    return View(cargoLogViewModel);
        //}

        //[HttpPost]
        //public ActionResult Back2(int cargoLogId)
        //{
        //    var cargoLog = _db.CargoLogInfo.Find(cargoLogId);
        //    if (cargoLog == null)
        //    {
        //        return Json(new { success = "fail", message = "还原失败 cargoLog == null" });
        //    }
        //    var cargo = _db.CargoInfo.Find(cargoLog.CargoInfoId);
        //    if (cargo == null)
        //    {
        //        return Json(new { success = "fail", message = "还原失败 cargo = null" });
        //    }
        //    if (cargoLog.IsIncome == true)
        //    {
        //        var count = _db.CargoLogInfo.Where(m => m.Id == cargoLogId).ToList().Count;
        //        cargo.CargoCount -= cargoLog.ChangeCount;
        //        //SELECT COUNT(*) FROM dbo.CargoLogInfo
        //        //GROUP BY CargoInfoId
        //        if (cargo.CargoCount < 0)
        //        {
        //            return Json(new { success = "fail", message = "库存为负数还原失败" });
        //        }

        //        if (count == 1)
        //        {
        //            cargo.CanDel = true;
        //        }
        //    }
        //    if (cargoLog.IsIncome == false)
        //    {
        //        cargo.CargoCount += cargoLog.ChangeCount;
        //    }

        //    var project = _db.ProjectInfo.Find(cargoLog.ProjectId);
        //    var projectCount = _db.CargoLogInfo.Where(m => m.ProjectId == project.Id).ToList().Count;
        //    if (projectCount == 1)
        //    {
        //        project.CanDel = true;
        //    }

        //    var supply = _db.SupplyInfo.Find(cargoLog.SupplyId);
        //    var supplyCount = _db.SupplyInfo.Where(m => m.Id == supply.Id).ToList().Count;
        //    if (supplyCount == 1)
        //    {
        //        supply.CanDel = true;
        //    }

        //    _db.Entry(project).Property(m => m.CanDel).IsModified = true;
        //    _db.Entry(supply).Property(m => m.CanDel).IsModified = true;

        //    _db.Entry(cargo).Property(m => m.CargoCount).IsModified = true;
        //    _db.Entry(cargo).Property(m => m.CanDel).IsModified = true;

        //    using (var tran = _db.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            if (_db.SaveChanges() > 0)
        //            {
        //                _db.CargoLogInfo.Remove(cargoLog);
        //                if (_db.SaveChanges() > 0)
        //                {
        //                    tran.Commit();
        //                    return Json(new { success = "success", message = "还原成功" });
        //                }
        //                else
        //                {
        //                    tran.Rollback();
        //                    return Json(new { success = "fail", message = "还原失败" });
        //                }

        //            }

        //            return Json(new { success = "fail", message = "还原失败" });
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //            throw;
        //        }
        //    }

        //}
        //#endregion

        //#region 项目查询
        //public ActionResult Project()
        //{
        //    ViewBag.ProjectName = new SelectList(_db.ProjectInfo, "Id", "ProjectName", 1);
        //    ViewBag.SupplyName = new SelectList(_db.SupplyInfo, "Id", "Name", 1);
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Project(CargoInfoViewModel cargoInfoViewModel, int limit, int offset)
        //{
        //    //var SQL = @"SELECT [t0].[Id] AS [CargoLogId], [t1].[CargoName],[t1].Id, [t0].[ChangeCount], [t0].[Time], [t2].[ProjectName], [t1].[DelFlag], [t2].[Id] AS [ProjectId] FROM [CargoLogInfo] AS [t0] INNER JOIN [CargoInfo] AS [t1] ON [t0].[CargoInfoId] = [t1].[Id] INNER JOIN [ProjectInfo] AS [t2] ON [t0].[ProjectId] = ([t2].[Id]) ";

        //    //var temp = _db.Database.SqlQuery<CargoInfoViewModel>(SQL);

        //    //var temp = from cargoLogInfo in _db.CargoLogInfo
        //    //           join cargoInfo in _db.CargoInfo on cargoLogInfo.CargoInfoId equals cargoInfo.Id
        //    //           join projectInfo in _db.ProjectInfo on cargoLogInfo.ProjectId equals projectInfo.Id
        //    //           select new { CargoLogId = cargoLogInfo.Id, cargoInfo.CargoName, cargoLogInfo.ChangeCount, cargoLogInfo.Time, projectInfo.ProjectName, cargoInfo.DelFlag, ProjectId = projectInfo.Id };

        //    var temp = (from t0 in _db.CargoLogInfo
        //                join t1 in _db.CargoInfo on new { t0.CargoInfoId } equals new { CargoInfoId = t1.Id }
        //                join supply in _db.SupplyInfo on t0.SupplyId equals supply.Id
        //                join user in _db.UserInfo on t0.UserId equals user.Id
        //                join t2 in _db.ProjectInfo on new { ProjectId = (int)t0.ProjectId } equals new { ProjectId = t2.Id }
        //                select new
        //                {
        //                    CargoLogId = t0.Id,
        //                    t1.CargoName,
        //                    t1.Id,
        //                    t0.ChangeCount,
        //                    t0.Time,
        //                    t2.ProjectName,
        //                    t1.DelFlag,
        //                    ProjectId = t2.Id,
        //                    t0.Desc,
        //                    t1.Unit,
        //                    t1.Specifications,
        //                    t1.Type,
        //                    t1.Amount,
        //                    t0.SupplyId,
        //                    SupplyName = supply.Name,
        //                    t0.TakenName,
        //                    user.UserName
        //                });

        //    if (cargoInfoViewModel.ProjectId != null)
        //    {
        //        temp = temp.Where(c => c.ProjectId == cargoInfoViewModel.ProjectId);
        //    }

        //    if (cargoInfoViewModel.SupplyId != null)
        //    {
        //        temp = temp.Where(c => c.SupplyId == cargoInfoViewModel.SupplyId);
        //    }

        //    if (cargoInfoViewModel.TimeEnd == DateTime.MinValue)
        //    {
        //        cargoInfoViewModel.TimeEnd = DateTime.MaxValue;
        //    }
        //    temp = temp.Where(c => cargoInfoViewModel.TimeStart <= c.Time && c.Time < cargoInfoViewModel.TimeEnd);

        //    var list = temp.OrderByDescending(c => c.Id).ToList();
        //    return Json(new { total = list.Count, rows = list.Skip(offset).Take(limit).ToList() });
        //}



        //#region 汇总

        //public ActionResult Assemble(CargoInfoViewModel cargoInfoViewModel, int limit, int offset) // group by
        //{
        //    var temp = from cargoLog in _db.CargoLogInfo
        //               join cargo in _db.CargoInfo on new { Id = cargoLog.CargoInfoId } equals new { cargo.Id }
        //               join supply in _db.SupplyInfo on cargoLog.SupplyId equals supply.Id
        //               join project in _db.ProjectInfo on new { Id = (int)cargoLog.ProjectId } equals new { project.Id }
        //               where
        //                   cargoLog.IsIncome == false
        //               group new { cargo, project, supply, cargoLog } by new
        //               {
        //                   cargo.Id,
        //                   cargo.CargoName,
        //                   cargo.Unit,
        //                   cargo.Specifications,
        //                   cargo.Amount,
        //                   project.ProjectName,
        //                   ProjectId = project.Id,
        //                   cargoLog.SupplyId,
        //                   SupplyName = supply.Name
        //               }
        //        into g
        //               select new
        //               {
        //                   g.Key.Id,
        //                   g.Key.CargoName,
        //                   g.Key.Unit,
        //                   g.Key.Specifications,
        //                   g.Key.Amount,
        //                   g.Key.ProjectId,
        //                   g.Key.ProjectName,
        //                   g.Key.SupplyId,
        //                   g.Key.SupplyName,
        //                   SumCount = (int?)g.Sum(p => p.cargoLog.ChangeCount),
        //                   SumAmount = g.Sum(p => (decimal)p.cargoLog.ChangeCount * p.cargo.Amount)
        //               };

        //    if (cargoInfoViewModel.ProjectId != null)
        //    {
        //        temp = temp.Where(c => c.ProjectId == cargoInfoViewModel.ProjectId);
        //    }

        //    if (cargoInfoViewModel.SupplyId != null)
        //    {
        //        temp = temp.Where(c => c.SupplyId == cargoInfoViewModel.SupplyId);
        //    }

        //    //if (cargoInfoViewModel.TimeEnd == DateTime.MinValue)
        //    //{
        //    //    cargoInfoViewModel.TimeEnd = DateTime.MaxValue;
        //    //}
        //    //temp2 = temp.Where(c => cargoInfoViewModel.TimeStart <= c.Time && c.Time < cargoInfoViewModel.TimeEnd);

        //    var list = temp.OrderByDescending(c => c.Id).ToList();
        //    return Json(new { total = list.Count, rows = list.Skip((int)offset).Take((int)limit).ToList() });
        //}
        //#endregion

        //#endregion

        //#region 导出Excel

        //public string Excel(CargoInfoViewModel cargoInfoViewModel)
        //{
        //    //var temp = from cargoLogInfo in _db.CargoLogInfo
        //    //           join cargoInfo in _db.CargoInfo on new { cargoLogInfo.CargoInfoId } equals new
        //    //           { CargoInfoId = cargoInfo.Id }
        //    //           join projectInfo in _db.ProjectInfo on new { Id = (int)cargoLogInfo.ProjectId } equals new { projectInfo.Id }
        //    //           where
        //    //               cargoLogInfo.IsIncome == false
        //    //           group new { cargoLogInfo, cargoInfo, projectInfo } by new
        //    //           {
        //    //               cargoLogInfo.CargoInfoId,
        //    //               cargoInfo.CargoName,
        //    //               projectInfo.ProjectName,
        //    //               projectInfo.Id
        //    //           }
        //    //    into g
        //    //           select new
        //    //           {
        //    //               商品号 = g.Key.CargoInfoId,
        //    //               商品名 = g.Key.CargoName,
        //    //               商品量 = (int?)g.Sum(p => p.cargoLogInfo.ChangeCount),
        //    //               项目名 = g.Key.ProjectName,
        //    //               项目编号 = g.Key.Id
        //    //           };
        //    var temp = from cargoLog in _db.CargoLogInfo
        //               join cargo in _db.CargoInfo on new { Id = cargoLog.CargoInfoId } equals new { cargo.Id }
        //               join project in _db.ProjectInfo on new { Id = (int)cargoLog.ProjectId } equals new { project.Id }
        //               where
        //                   cargoLog.IsIncome == false
        //               group new { cargo, project, cargoLog } by new
        //               {
        //                   cargo.Id,
        //                   cargo.CargoName,
        //                   cargo.Unit,
        //                   cargo.Specifications,
        //                   cargo.Amount,
        //                   project.ProjectName,
        //                   projectId = project.Id
        //               }
        //        into g
        //               select new
        //               {
        //                   商品号 = g.Key.Id,
        //                   商品名 = g.Key.CargoName,
        //                   单位 = g.Key.Unit,
        //                   规格型号 = g.Key.Specifications,
        //                   单价 = g.Key.Amount,
        //                   项目号 = (int?)g.Key.projectId,
        //                   项目名 = g.Key.ProjectName,
        //                   商品总量 = (int?)g.Sum(p => p.cargoLog.ChangeCount),
        //                   总金额 = g.Sum(p => (decimal)p.cargoLog.ChangeCount * p.cargo.Amount)
        //               };

        //    if (cargoInfoViewModel.ProjectId != null)
        //    {
        //        temp = temp.Where(c => c.项目号 == cargoInfoViewModel.ProjectId);
        //    }

        //    //if (cargoInfoViewModel.TimeEnd == DateTime.MinValue)
        //    //{
        //    //    cargoInfoViewModel.TimeEnd = DateTime.MaxValue;
        //    //}
        //    //temp2 = temp.Where(c => cargoInfoViewModel.TimeStart <= c.Time && c.Time < cargoInfoViewModel.TimeEnd);

        //    var list = temp.OrderByDescending(c => c.项目号).ToList();


        //    var filePath = ToExcel(list);
        //    return filePath;
        //}

        //public string ExcelCargo(CargoInfoViewModel cargoInfoViewModel)
        //{
        //    var temp = (from cargoInfo in _db.CargoInfo select new { 商品号 = cargoInfo.Id, 商品名 = cargoInfo.CargoName, 金额 = cargoInfo.Amount, 数量 = cargoInfo.CargoCount, 单位 = cargoInfo.Unit, cargoInfo.DelFlag, 规格型号 = cargoInfo.Specifications, 存放区域 = cargoInfo.Area }).Where(c => c.DelFlag == false).Select(cargoInfo => new
        //    {
        //        cargoInfo.商品号,
        //        cargoInfo.商品名,
        //        cargoInfo.金额,
        //        cargoInfo.数量,
        //        cargoInfo.单位,
        //        cargoInfo.规格型号,
        //        cargoInfo.存放区域
        //    });

        //    if (cargoInfoViewModel.Id != 0)
        //    {
        //        temp = temp.Where(c => c.商品号 == cargoInfoViewModel.Id);
        //    }
        //    if (!cargoInfoViewModel.CargoName.IsEmpty())
        //    {
        //        //temp = temp.Where(c => c.CargoName.Contains(cargoInfoViewModel.CargoName)); // 模糊
        //        temp = temp.Where(c => c.商品名 == cargoInfoViewModel.CargoName);
        //    }
        //    var list = temp.OrderByDescending(c => c.商品号).ToList();


        //    var filePath = ToExcel(list);
        //    return filePath;
        //}

        //public string ToExcel<T>(List<T> list)
        //{
        //    string fileName = "/Excel/" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xls";
        //    string filePath = HttpRuntime.AppDomainAppPath + fileName;

        //    HSSFWorkbook book = new HSSFWorkbook();
        //    ISheet sheet1 = book.CreateSheet("sheet1");

        //    var row = sheet1.CreateRow(0);
        //    PropertyInfo[] propertyInfos = typeof(T).GetProperties();

        //    for (int i = 0; i < propertyInfos.Length; i++)
        //    {
        //        var temp = row.CreateCell(i);
        //        temp.SetCellValue(propertyInfos[i].Name);
        //    }

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        var row0 = sheet1.CreateRow(i + 1);
        //        for (int j = 0; j < propertyInfos.Length; j++)
        //        {
        //            var cell0 = row0.CreateCell(j);
        //            cell0.SetCellValue(propertyInfos[j].GetValue(list[i], null) == null ? "" : propertyInfos[j].GetValue(list[i], null).ToString());
        //        }
        //    }

        //    MemoryStream memoryStream = new MemoryStream();
        //    book.Write(memoryStream);
        //    FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);

        //    memoryStream.WriteTo(fileStream);
        //    memoryStream.Dispose();
        //    fileStream.Dispose();

        //    return fileName;
        //}
        //#endregion
    }
}