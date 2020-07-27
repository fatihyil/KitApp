using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminBookEditVM
    {
        public int Id { get; set; }          
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int BookPages { get; set; }
        public string BookName { get; set; }
    }
}
