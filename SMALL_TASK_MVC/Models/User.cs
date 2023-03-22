
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SMALL_TASK_MVC.Models
{
    public class User
    {
        [Display(Name = "Enter first name:")]
        [Required(ErrorMessage = "Has to be filled!")]
        public string FirstName { get; set; }

        [Display(Name = "Enter surname:")]
        [Required(ErrorMessage = "Has to be filled!")]
        public string Surname { get; set; }
    }
}
