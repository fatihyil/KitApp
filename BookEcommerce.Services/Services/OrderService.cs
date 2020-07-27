using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class OrderService
    {
        private readonly BookEcommerceDbContext _context;

        public OrderService(BookEcommerceDbContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders()
        {
            return  _context.Order.ToList();
        }

        public void Add(Order entity)
        {
            _context.Order.Add(entity);
            _context.SaveChanges();
        }

        public Order GetById(int ıd)
        {
            return _context.Order.Find(ıd);
            
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
