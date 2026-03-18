using System.ComponentModel.DataAnnotations;

namespace PlantSaleUI.Models
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        public string password { get; set; }
    }
}
