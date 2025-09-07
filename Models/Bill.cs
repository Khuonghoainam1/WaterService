namespace WebThanhToanTienNuoc.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string MaKH { get; set; } = "";
        public string TenChuHo { get; set; } = "";
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public int SoTieuThu => ChiSoMoi - ChiSoCu;
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoTieuThu * DonGia;
        public string KyHoaDon { get; set; } = ""; // Ví dụ: "08/2024"
        public bool DaThanhToan { get; set; } = false;
    }
}
