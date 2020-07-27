using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Girmelisiniz !")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifrenizi Girmelisiniz !")]
        public string Password { get; set; }
    }
}
