using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Display(Name ="Date of Order")]
        public DateTime DateOrder { get; set; }
        [Display(Name ="Cash Invoice Number")]
        public int InvoiceNumber { get; set; }
        [Display(Name ="Official Receipt Number")]
        public int ORNumber { get; set; }
        [Display(Name ="Total Price of Product Ordered")]
        public int TotalPrice { get; set; }
        public int BrandId { get; set; }


        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }

    }
}
