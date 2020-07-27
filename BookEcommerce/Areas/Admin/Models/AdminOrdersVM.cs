using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminOrdersVM
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public decimal? TotalPrice { get; set; }
        public int OrderDetailId { get; set; }

        public List<AdminOrderDetailVM> OrderDetailVMs { get; set; }
    }
}
