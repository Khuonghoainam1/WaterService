namespace WebThanhToanTienNuoc.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Period { get; set; } = ""; // VD: "08/2025"
        public decimal TotalAmount { get; set; }
        public bool Paid { get; set; } = false;
    }
}
