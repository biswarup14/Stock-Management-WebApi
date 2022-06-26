using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalStockManage.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        [Display(Name ="First Name of Employee")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        [Display(Name = "Last Name of Employee")]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="Employee Full Address")]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Phone Number")]
        public string ContactNumber { get; set; }
        [Display(Name ="Position of Employee")]
        public string Position { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
