using Microsoft.AspNetCore.Mvc;

namespace WebThanhToanTienNuoc.Controllers
{
    public class AdminController: Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
