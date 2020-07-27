using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Models
{
    public class ShoppingPageVM
    {
        public List<ShoppingCardVM> shoppingCards { get; set; }
        public decimal SumPrice { get; set; }
    }
}
