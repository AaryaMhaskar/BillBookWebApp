using System.ComponentModel.DataAnnotations;

namespace BillBookSystem.Models
{
    public class Invoices
    {
        [Key] 
        public int Invoiceid { get; set; }
        public string InvoiceStatus { get; set; }
        // other properties...
    }
}
