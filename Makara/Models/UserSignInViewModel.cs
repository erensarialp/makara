﻿using System.ComponentModel.DataAnnotations;

namespace StajProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi  giriniz")]
        public string password { get; set; }


    }
}
