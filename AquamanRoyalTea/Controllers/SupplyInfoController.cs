using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bll;
using Model;
using Model.DbQueryModel;

namespace AquamanRoyalTea.Controllers
{
    public class SupplyInfoController : BaseController
    {

        private readonly SupplyInfoService _supplyInfoService = new SupplyInfoService();

        #region 供应商信息
        public ActionResult Index()
        {
            //ViewBag.PowerInfoId = LoginUser.UserPrivilegesId;
            //_supplyInfoService.
            return View();
        }

        [HttpPost]
        public ActionResult Index(SupplyInfoViewModel supplyInfoViewModel, int limit, int offset)
        {
            //var temp = _db.SupplyInfo.Where(m => m.DelFlag == false);
            //if (supplyInfoViewModel.Id != 0)
            //{
            //    temp = temp.Where(c => c.Id == supplyInfoViewModel.Id);
            //}
            //if (!supplyInfoViewModel.Company.IsEmpty())
            //{
            //    temp = temp.Where(c => c.Company.Contains(supplyInfoViewModel.Company)); // 模糊
            //    //temp = temp.Where(c => c.Company == SupplyInfoViewModel.Company);
            //}
            //var list = temp.OrderByDescending(c => c.Id).ToList();
            //return Json(new { total = list.Count, rows = list.Skip(offset).Take(limit).ToList() });
            return Json("");
        }
        #endregion

        #region 添加供应商
        public ActionResult Create()
        {
            //if (LoginUser.PowerInfoId != 1 && LoginUser.PowerInfoId != 2)
            //{
            //    return Redirect("login/logoff");
            //}
            ////ViewBag.Power = new SelectList(_db.PowerInfo, "Id", "PowerName", 1);
            //var supply = new SupplyViewModel();
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(SupplyInfoViewModel supplyInfoViewModel)
        {
            //if (supplyInfoViewModel.Name.Replace(" ", "").Replace("  ", "").IsEmpty())
            //{
            //    return Json(new { success = "fail", message = "请输入供应商名" });
            //}
            //var supplyInfo = new SupplyInfo()
            //{
            //    Company = supplyInfoViewModel.Company.Replace(" ", "").Replace("  ", ""),
            //    Name = supplyInfoViewModel.Name.Replace(" ", "").Replace("  ", ""),
            //    Address = supplyInfoViewModel.Address,
            //    Phone = supplyInfoViewModel.Phone,
            //    CanDel = true,
            //};
            //var supply = _db.SupplyInfo.FirstOrDefault(c => c.Company == supplyInfo.Company && c.Name == supplyInfo.Name && c.Address == supplyInfo.Address);
            //if (supply != null)
            //{
            //    return Json(new { success = "fail", message = "这个供应商已经存在" });
            //}
            ////var temp = _db.CargoInfo.Add(userInfo);
            //_db.SupplyInfo.Add(supplyInfo);
            //return _db.SaveChanges() > 0 ? Json(new { success = "success", message = "添加成功" }) : Json(new { success = "fail", message = "" });
            return Json(new { success = "fail", message = "" });
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
            //            where supplyInfo.Id == id
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
            //return Json(new { total = list.Count, rows = list.OrderByDescending(c => c.Time).Skip(offset).Take(limit).ToList() });
            return Json("");
        }
        #endregion

        #region 修改供应商信息
        public ActionResult Edit(int id)
        {
            //var supply = _db.SupplyInfo.Find(id);
            //if (supply == null)
            //{
            //    return Redirect("index"); // not find
            //}
            //var model = new SupplyViewModel(supply);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(SupplyInfo supplyInfo)
        {
            //var supply = _db.SupplyInfo.Find(supplyInfo.Id);
            //if (supply == null)
            //{
            //    return Json(new { success = "fail", message = "修改失败，没有当前的供应商" });
            //}
            //var temp = _db.SupplyInfo.FirstOrDefault(s => s.Name == supplyInfo.Name.Replace(" ", "").Replace("  ", "") && s.Company == supplyInfo.Company.Replace(" ", "").Replace("  ", "") && s.Address == supplyInfo.Address && s.Phone == supplyInfo.Phone);
            //if (temp != null)
            //{
            //    return Json(new { success = "fail", message = "修改失败，已经有这个商品" });
            //}

            //supply.Name = supplyInfo.Name.Replace(" ", "").Replace("  ", "");
            //supply.Company = supplyInfo.Company;
            //supply.Phone = supplyInfo.Phone;
            //supply.Address = supplyInfo.Address;

            //_db.SupplyInfo.Attach(supply);
            //_db.Entry(supply).Property(c => c.Name).IsModified = true;
            //_db.Entry(supply).Property(c => c.Company).IsModified = true;
            //_db.Entry(supply).Property(c => c.Phone).IsModified = true;
            //_db.Entry(supply).Property(c => c.Address).IsModified = true;

            //return _db.SaveChanges() > 0
            //    ? Json(new { success = "success", message = "修改成功" })
            //    : Json(new { success = "fail", message = "修改失败" });
            return Json("");
        }
        #endregion

        #region 删除供应商
        public ActionResult Delete(int id)
        {
            //var supply = _db.SupplyInfo.Find(id);
            //if (supply == null)
            //{
            //    return Redirect("index");
            //}
            //var model = new SupplyViewModel(supply);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(SupplyInfo supplyInfo)
        {
            //var supply = _db.SupplyInfo.Find(supplyInfo.Id);
            //_db.SupplyInfo.Remove(supply);
            //return _db.SaveChanges() > 0
            //    ? Json(new { success = "success", message = "删除成功" })
            //    : Json(new { success = "fail", message = "删除失败" });
            return Json(new { success = "fail", message = "删除失败" });
        }
        #endregion
    }
}