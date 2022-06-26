using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Display(Name ="Supplier's Name")]
        [StringLength(50,MinimumLength =3)]
        public string SupplierName { get; set; }
        [Display(Name ="Supplier's Address")]
        [StringLength(100,MinimumLength =6)]
        public string SupplierAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int ContactNumber { get; set; }

        [ForeignKey("Product")]
        public int BrandId { get; set; }
        public Product Product { get; set; }    
    }
}
