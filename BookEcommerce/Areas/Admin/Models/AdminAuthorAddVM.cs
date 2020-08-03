using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminAuthorAddVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Yazarın Adını giriniz !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yazarın Soyadını giriniz !")]
        public string Surname { get; set; }

    }
}
