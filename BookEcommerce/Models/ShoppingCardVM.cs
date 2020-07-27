using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Models
{
    public class ShoppingCardVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        public int Price { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
       
    }
}
