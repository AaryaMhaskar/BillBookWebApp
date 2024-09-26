using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BillBookSystem.Models
{
    public class sale
    {
        [Key]
        //public int Id { get; set; }

        public int BillTo { get; set; }

       // public int ShopTo { get; set; }

        public int InvoiceId { get; set; }

        public DateTime InvoiceDate { get; set; }

       // public int InvoicedItemId { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
    }
}
