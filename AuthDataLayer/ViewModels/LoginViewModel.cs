using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthDataLayer.ViewModels
{
    public class LoginViewModel
    {
        
        [MaxLength(20, ErrorMessage = "Слишком длинный логин товарищ")]
        [Required(ErrorMessage = "Нужно ввести")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Нужно ввести")]
        public string Password { get; set; }
    }
}
