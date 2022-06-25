using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Date Received of Product")]
        public DateTime DateReceived { get; set; }
        public int BrandId { get; set; }
        [Display(Name ="Brand Name of Product")]
        public string BrandName { get; set; }
        [Display(Name ="Model of Product")]
        public string Model { get; set; }
        [Display(Name ="Serial Number of Product")]
        public int SerialNumber { get; set; }
        [Display(Name ="Quantity of Product available")]
        public int Availability { get; set; }
        
        public DateTime DateSold { get; set; }
        [Display(Name ="Type of Product Unit Sold")]
        public string UnitType { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Supplier>Suppliers { get; set; }
    }
}
