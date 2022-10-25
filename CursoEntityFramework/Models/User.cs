using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityFramework.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        //[RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Invalid email, enter valid email")]
        [EmailAddress(ErrorMessage = "Invalid email, enter valid email")]
        public string Email { get; set; }

        [Display(Name = "User Address")]
        public string Address { get; set; }
        
        [NotMapped]
        public int Age { get; set; }
    }
}
