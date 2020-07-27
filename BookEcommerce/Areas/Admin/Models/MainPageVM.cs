using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class MainPageVM
    {
        public int BookCount { get; set; }
        public int PublisherCount { get; set; }
        public int AuthorCount { get; set; }
        public int OrderCount { get; set; }
    }
}
