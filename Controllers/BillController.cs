using Microsoft.AspNetCore.Mvc;
using WebThanhToanTienNuoc.Models;
namespace WebThanhToanTienNuoc.Controllers
{
    public class BillController : Controller
    {

        // Mock danh sách hộ dân
        private List<Bill> fakeBills = new List<Bill>
        {
            new Bill { Id = 1, MaKH = "KH001", TenChuHo = "Nguyễn Văn A", ChiSoCu = 120 },
            new Bill { Id = 2, MaKH = "KH002", TenChuHo = "Trần Thị B", ChiSoCu = 95 },
            new Bill { Id = 3, MaKH = "KH003", TenChuHo = "Lê Văn C", ChiSoCu = 150 }
        };

        public IActionResult BillAndReading()
        {
            ViewBag.Thang = DateTime.Now.Month;
            ViewBag.Nam = DateTime.Now.Year;
            ViewBag.DonGia = 10000;
            return View(fakeBills);
        }

        [HttpPost]
        public IActionResult BillAndReading(List<Bill> bills, int Thang, int Nam, decimal DonGia)
        {
            foreach (var b in bills)
            {
                b.KyHoaDon = $"{Thang:D2}/{Nam}";
                b.DonGia = DonGia;
                Console.WriteLine($"{b.MaKH} - {b.TenChuHo} | Thực dùng: {b.SoTieuThu} | Thành tiền: {b.ThanhTien}");
            }

            ViewBag.Message = "Đã lưu chỉ số và tạo hóa đơn (demo).";
            ViewBag.Thang = Thang;
            ViewBag.Nam = Nam;
            ViewBag.DonGia = DonGia;

            return View(bills);
        }
    }
}
