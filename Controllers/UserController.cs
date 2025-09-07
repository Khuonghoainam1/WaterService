using Microsoft.AspNetCore.Mvc;
using WebThanhToanTienNuoc.Models;

namespace WebThanhToanTienNuoc.Controllers
{
    public class UserController : Controller
    {
        // Mock dữ liệu khách hàng
        private static List<Customer> fakeCustomers = new List<Customer>
        {
            new Customer
            {
                MaKH = "KH001",
                TenChuHo = "Nguyễn Văn A",
                SoDienThoai = "0901234567",
                DiaChi = new Address { Id = 1, ThonXom = "Thôn 1", GhiChu = "Gần UBND xã" },
                Bills = new List<Bill>
                {
                    new Bill { Id = 1, MaKH = "KH001", TenChuHo = "Nguyễn Văn A", ChiSoCu = 100, ChiSoMoi = 120, DonGia = 10000, KyHoaDon = "07/2024", DaThanhToan = true },
                    new Bill { Id = 2, MaKH = "KH001", TenChuHo = "Nguyễn Văn A", ChiSoCu = 120, ChiSoMoi = 145, DonGia = 11000, KyHoaDon = "08/2024", DaThanhToan = false }
                }
            },
            new Customer
            {
                MaKH = "KH002",
                TenChuHo = "Trần Thị B",
                SoDienThoai = "0987654321",
                DiaChi = new Address { Id = 2, ThonXom = "Thôn 2", GhiChu = "" },
                Bills = new List<Bill>
                {
                    new Bill { Id = 3, MaKH = "KH002", TenChuHo = "Trần Thị B", ChiSoCu = 90, ChiSoMoi = 100, DonGia = 10000, KyHoaDon = "07/2024", DaThanhToan = true }
                }
            }
        };

        // Trang nhập mã KH
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(string maKH)
        {
            var customer = fakeCustomers.FirstOrDefault(c => c.MaKH == maKH || c.SoDienThoai == maKH);
            if (customer == null)
            {
                ViewBag.Error = "Không tìm thấy thông tin khách hàng.";
                return View("Index");
            }
            return View(customer);
        }
    }
}
