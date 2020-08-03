using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminCategoryVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kategori Adı girmelisiniz !")]
        public string Name { get; set; }

    }
}
