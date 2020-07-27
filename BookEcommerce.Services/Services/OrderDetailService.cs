using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BookEcommerce.Services.Services
{
    public class OrderDetailService
    {
        private readonly BookEcommerceDbContext _context;
        public OrderDetailService(BookEcommerceDbContext context)
        {
            _context = context;
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int id)
        {
            return _context.OrderDetail.Where(x => x.OrderId == id).ToList();
        }
        public void Add(OrderDetail entity)
        {
            _context.OrderDetail.Add(entity);
            _context.SaveChanges();
        }
    }
}
