using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyNhaSach_.Models;
namespace QuanLyNhaSach_.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        _QuanLyBanSachDataContext db = new _QuanLyBanSachDataContext();
        public ActionResult SachPatial()
        {
            return View(db.Saches.ToList());
        }
        
    }
}