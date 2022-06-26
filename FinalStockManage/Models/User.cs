using System.ComponentModel.DataAnnotations;

namespace FinalStockManage.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(50,MinimumLength =3)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50,MinimumLength =3)]
        public string ?LastName { get; set; }
        [Required]
        [StringLength(200,MinimumLength =5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        public bool IsActive { get; set; }=true;
        
       
    }
}
