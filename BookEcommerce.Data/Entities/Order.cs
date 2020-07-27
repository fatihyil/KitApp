using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }       
        public DateTime AddDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public decimal? TotalPrice { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
