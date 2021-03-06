﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminPublisherVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Yayıncı Adını giriniz !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yayıncı Adresi giriniz !")]
        public string Address { get; set; }
    }
}
