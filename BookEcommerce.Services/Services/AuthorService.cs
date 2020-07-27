using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class AuthorService
    {
        private readonly BookEcommerceDbContext _context;
        public AuthorService(BookEcommerceDbContext context)
        {
            _context = context;
        }

        public List<Author> GetAuthors()
        {
            return _context.Author.ToList();
        }
    }
}
