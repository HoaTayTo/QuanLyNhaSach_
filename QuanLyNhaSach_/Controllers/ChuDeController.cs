using QuanLyNhaSach_.Models;
using System.Linq;
using System.Web.Mvc;
namespace QuanLyNhaSach_.Controllers
{
    public class ChuDeController : Controller
    {
        // GET: ChuDe
        _QuanLyBanSachDataContext db = new _QuanLyBanSachDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChuDePaqqrtial()
        {
            return View(db.ChuDes.Take(7).ToList());
        }
        public ActionResult SachTheoCD(int MaCD)
        {
            return View(db.Saches.Where(sach=>sach.MaChuDe==MaCD).ToList());
        }


    }
}