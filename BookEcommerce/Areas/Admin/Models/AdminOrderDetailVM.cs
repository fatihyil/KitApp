using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminOrderDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
