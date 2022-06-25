using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Display(Name ="Supplier's Name")]
        public string SupplierName { get; set; }
        [Display(Name ="Supplier's Address")]
        public string SupplierAddress { get; set; }
        public int ContactNumber { get; set; }

        [ForeignKey("Product")]
        public int BrandId { get; set; }
        public Product Product { get; set; }    
    }
}
