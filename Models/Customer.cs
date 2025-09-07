namespace WebThanhToanTienNuoc.Models
{
     public class Customer
    {
        public string MaKH { get; set; } = "";
        public string TenChuHo { get; set; } = "";
        public string SoDienThoai { get; set; } = "";

        // Thay string DiaChi bằng Address
        public Address DiaChi { get; set; } = new Address();

        public List<Bill> Bills { get; set; } = new List<Bill>();
    }
}
