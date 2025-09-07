using Microsoft.AspNetCore.Mvc;
using WebThanhToanTienNuoc.Models;
namespace WebThanhToanTienNuoc.Controllers
{
    public class WaterUserController : Controller
    {
        // Mock data (sau này thay bằng DB)
        private static List<User> ListUser = new List<User>
        {
            new User { MaKH = "KH001", TenChuHo = "Nguyen Van A", DiaChi = "Hà Nội", SoDT = "0912345678" },
            new User { MaKH = "KH002", TenChuHo = "Tran Thi B", DiaChi = "HCM", SoDT = "0987654321" }
        };

        public IActionResult Index(string search)
        {
            var ds = ListUser.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                ds = ds.Where(x =>
                    x.MaKH.Contains(search) ||
                    x.TenChuHo.Contains(search) ||
                    x.SoDT.Contains(search));
            }

            ViewBag.Search = search;
            return View(ds.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                ListUser.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Details(string id)
        {
            var hoDan = ListUser.FirstOrDefault(x => x.MaKH == id);
            if (hoDan == null) return NotFound();
            return View(hoDan);
        }
      public IActionResult UserManager(string search)
{
    var ds = ListUser.AsQueryable();

    if (!string.IsNullOrEmpty(search))
    {
        ds = ds.Where(x =>
            x.MaKH.Contains(search) ||
            x.TenChuHo.Contains(search) ||
            x.SoDT.Contains(search));
    }

    ViewBag.Search = search;
    return View(ds.ToList()); // sẽ render ra Views/WaterUser/UserManager.cshtml
}

    }

}
