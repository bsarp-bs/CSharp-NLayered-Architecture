using System.ComponentModel.DataAnnotations;

namespace PlantSaleUI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        [Compare("Password",ErrorMessage =("Şifreler Uyumlu Değil"))]
        public string PasswordConfirm { get; set; }

    }
}
