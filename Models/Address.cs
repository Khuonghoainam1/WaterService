namespace WebThanhToanTienNuoc.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string ThonXom { get; set; } = "";   // Tên thôn/xóm
        public string GhiChu { get; set; } = "";    // Ghi chú thêm (tùy chọn)

        public override string ToString()
        {
            return string.IsNullOrEmpty(GhiChu) ? ThonXom : $"{ThonXom} ({GhiChu})";
        }
    }
}
