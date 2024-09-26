using System.ComponentModel.DataAnnotations;

namespace BillBookSystem.Models
{
    public class SalesDetails
    {
        [Key]
        public decimal Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int BillTo { get; set; }
        public int InventoryItemid { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
