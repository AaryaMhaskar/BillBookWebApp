using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BillBookSystem.Models
{
    public class Inventory

    {
        [Key]
        //public int Id { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string? ItemType { get; set; }

        //public int CategoryId { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string? ItemName { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal SalesPrice { get; set; }

        //[Column(TypeName = "decimal(5, 2)")]
        //public decimal GstTaxRate { get; set; }

        //[StringLength(50)]
        //public string? MeasuringUnit { get; set; }

        //public int OpeningStock { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal PurchasePrice { get; set; }

        //[StringLength(255)]
        //public string? ItemCodeMhsnCodeMDescription { get; set; }

        //[StringLength(255)]
        //public string? Image { get; set; }

        //public int BusinessId { get; set; }
    }
}
