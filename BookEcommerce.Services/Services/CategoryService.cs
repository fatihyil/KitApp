using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class CategoryService
    {
        private readonly BookEcommerceDbContext _context;
        public CategoryService(BookEcommerceDbContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            return _context.Category.ToList();
        }

        public void Add(Category entity)
        {
            _context.Category.Add(entity);
            _context.SaveChanges();
        }
    }
}
