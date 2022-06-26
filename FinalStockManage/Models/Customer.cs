using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string ContactNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; } 
    }
}
