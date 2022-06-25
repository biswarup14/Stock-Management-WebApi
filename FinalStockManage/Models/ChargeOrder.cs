using System.ComponentModel.DataAnnotations;

namespace FinalStockManage.Models
{
    public class ChargeOrder
    {
        [Key]
        public int ChargeOrderId { get; set; }
        [Display(Name ="Cash Invoice Number")]
        public int InvoiceNumber { get; set; }
        [Display(Name ="Brand Name of Product")]
        public string BrandName { get; set; }
        [Display(Name ="Model of Product")]
        public string Model { get; set; }
        [Display(Name ="Type of Unit Sold")]
        public string UnitType { get; set; }
        [Display(Name ="Serial Number of Product")]
        public int SerialNumber { get; set; }
        [Display(Name ="Product Price")]
        public int Price { get; set; }
        [Display(Name ="Down Payment of Product")]
        public int DownPayment { get; set; }
        [Display(Name ="Number of Months Term of Product")]
        public int MonthTerm { get; set; }
        [Display(Name ="Customer's Monthly Payment")]
        public int MonthlyPayment { get; set; }

    }
}
