using System.ComponentModel.DataAnnotations;

namespace KareAjans.MVC.Models.ViewModel
{
    public class RegisterVM
    {
        //dataannotations propertylerle ilgili işlemleri yapmamza sağlıyor.
        [Required(ErrorMessage = "Email adresi boş geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre (tekrar) boş geçilemez!")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
