using System.ComponentModel.DataAnnotations;

namespace FinalStockManage.Models
{
    public class CashOrder
    {
        [Key]
        public int CashOrderId { get; set; }
        [Display(Name ="OrderID Number")]
        public int OrderId { get; set; }
        [Display(Name ="Brand Name of Product")]
        public string BrandName { get; set; }
        [Display(Name ="Model of Product")]
        public string Model { get; set; }
        [Display(Name ="Serial Number of Product")]
        public int SerialNumber { get; set; }
        [Display(Name ="Price of Product")]
        public int Price { get; set; }
        [Display(Name ="Cash Invoice Number")]
        public int InvoiceNumber { get; set; }
    }
}
