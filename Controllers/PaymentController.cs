using Microsoft.AspNetCore.Mvc;
using WebThanhToanTienNuoc.Models;

namespace WebThanhToanTienNuoc.Controllers
{
    public class PaymentController : Controller
    {
        // Mock danh sách hóa đơn
        private static List<Bill> fakeBills = new List<Bill>
        {
            new Bill { Id = 1, MaKH = "KH001", TenChuHo = "Nguyễn Văn A", ChiSoCu = 120, ChiSoMoi=150, DonGia=10000, KyHoaDon="08/2025", DaThanhToan=false },
            new Bill { Id = 2, MaKH = "KH002", TenChuHo = "Trần Thị B", ChiSoCu = 95, ChiSoMoi=110, DonGia=10000, KyHoaDon="08/2025", DaThanhToan=true }
        };

        public IActionResult Index(int billId)
        {
            var bill = fakeBills.FirstOrDefault(x => x.Id == billId);
            if (bill == null) return NotFound();

            return View(bill);
        }

        [HttpPost]
        public IActionResult Pay(int billId)
        {
            var bill = fakeBills.FirstOrDefault(x => x.Id == billId);
            if (bill == null) return NotFound();

            bill.DaThanhToan = true;

            ViewBag.Message = "Thanh toán thành công!";
            return View("Index", bill);
        }
    }
}
