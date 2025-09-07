using Microsoft.AspNetCore.Mvc;
using WebThanhToanTienNuoc.Models;
namespace WebThanhToanTienNuoc.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel()); 
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                // Nếu đúng thì chuyển sang trang quản lý
                return RedirectToAction("Dashboard", "Admin");
            }
            // Nếu sai thì báo lỗi
            model.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng!";
            return View(model);
        }
        
    }
}
