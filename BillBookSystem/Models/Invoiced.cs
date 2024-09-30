using System.ComponentModel.DataAnnotations;

namespace BillBookSystem.Models
{
    public class Invoiced
    {
        [Key]
        public int Id { get; set; }

        public int SalesId { get; set; }

        public int InvoiceId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int InventoryItemId { get; set; }

        public String? InvoiceStatus { get; set; }
    }
}
