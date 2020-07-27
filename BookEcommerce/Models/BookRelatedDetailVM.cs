using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Models
{
    public class BookRelatedDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BookImgUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int BookPages { get; set; }

        //public List<BooksVM> books { get; set; }
        public List<ReletedBooksVM> books { get; set; }

    }
}
