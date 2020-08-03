using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class PublisherService
    {
        private readonly BookEcommerceDbContext _context;
        public PublisherService(BookEcommerceDbContext context)
        {
            _context = context;
        }


        public List<Publisher> GetPublishers()
        {
            return _context.Publisher.ToList();
        }
        public void Add(Publisher publisher)
        {
            _context.Publisher.Add(publisher);
            _context.SaveChanges();
        }
    }
}
