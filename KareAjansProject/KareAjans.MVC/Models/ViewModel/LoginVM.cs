using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KareAjans.MVC.Models.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [Display(Name = "Eposta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
