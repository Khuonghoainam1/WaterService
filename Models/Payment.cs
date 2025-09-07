using System.ComponentModel.DataAnnotations;

namespace WebThanhToanTienNuoc.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; } = DateTime.Today;

        [Required]
        public PaymentMethod Method { get; set; }

        public string? ReferenceNumber { get; set; }
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual Bill Invoice { get; set; } = null!;
    }

    public enum PaymentMethod
    {
        Cash,
        BankTransfer,
        CreditCard,
        Check,
        Online
    }
}