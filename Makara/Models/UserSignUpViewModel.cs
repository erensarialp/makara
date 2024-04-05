using System.ComponentModel.DataAnnotations;

namespace StajProje.Models
{
    
    public class UserSignUpViewModel
    {
        [Display(Name="Ad Soyad")]
        [Required(ErrorMessage ="Lutfen ad soyad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lutfen sifre giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Sifreler uyusmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lutfen mail giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanici Adi")]
        [Required(ErrorMessage = "Lutfen kullanici adinizi giriniz")]
        public string UserName { get; set; }
    }
}
