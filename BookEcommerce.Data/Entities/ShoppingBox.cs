using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class ShoppingBox
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
    }
}
