using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class ShoppingBoxService
    {
        private readonly BookEcommerceDbContext _context;
        public ShoppingBoxService(BookEcommerceDbContext context)
        {
            _context = context;
        }
        public void  Add(ShoppingBox shoppingBox)
        {
            _context.ShoppingBox.Add(shoppingBox);
            _context.SaveChanges();            
        }

        public List<ShoppingBox> GetCards()
        {
            var entities = _context.ShoppingBox.ToList();
            return entities;
        }

        public void DeleteShopCard(int id)
        {
            var entity = _context.ShoppingBox.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }

}
