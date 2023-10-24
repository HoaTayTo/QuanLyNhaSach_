using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyNhaSach_.Models;
namespace QuanLyNhaSach_.Controllers
{
    public class NhaXuatBanController : Controller
    {
        // GET: NhaXuatBan
        _QuanLyBanSachDataContext db = new _QuanLyBanSachDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NhaXuaBanPatial()
        {
            return View(db.NhaXuatBans.Take(7).ToList());
        }
    }
}