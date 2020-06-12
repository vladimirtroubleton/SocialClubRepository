using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AuthDataLayer.Models
{
    public class UserModel
    {
        [MaxLength(20)]
        [Required(ErrorMessage = "Identifier too long (16 character limit).")]
        [Key]
        public string Login { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [MaxLength(15)]
        
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress)]
        [MaxLength(60)]
        public string Email { get; set; }
        [MaxLength(3)]
        public int Age { get; set; }
        public string Password { get; set; }

        public string AvatarPath { get; set; }
    }
}
