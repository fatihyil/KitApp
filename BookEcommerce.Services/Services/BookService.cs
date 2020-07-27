using BookEcommerce.Data.Context;
using BookEcommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookEcommerce.Services.Services
{
    public class BookService
    {
        private readonly BookEcommerceDbContext _context;
        public BookService(BookEcommerceDbContext context)
        {
            _context = context;
        }
        public List<Book> GetBooks()
        {
            return _context.Book.ToList();
        }
        public Book GetBookById(int id)
        {
            return _context.Book.FirstOrDefault(q=> q.Id == id);
        }
        public List<Book> GetBooksByCategoryId(int id)
        {
            return _context.Book.Where(x => x.CategoryId == id).Take<Book>(4).ToList();
        }

        public void Delete(int id)
        {
            var entity = _context.Book.FirstOrDefault(x => x.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
        public int Edit(Book book)
        {
            var entity = _context.Book.FirstOrDefault(x => x.Id == book.Id);
            _context.Book.Update(entity);
            _context.SaveChanges();
            //Kotrol yapılacak
            return 1;
        }
        public void Add(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
        }
    }
}
