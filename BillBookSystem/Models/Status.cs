using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillBookSystem.Models
{
    public class Status
    {
        [Key]
        public int Invoiceid { get; set; } 

        [Required]
        [StringLength(100)]
        public string InvoiceStatus { get; set; }
    }
}
