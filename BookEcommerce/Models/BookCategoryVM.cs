using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Models
{
    public class BookCategoryVM
    {
        public List<BooksVM> Books { get; set; }
        public List<CategoryVM> Categories { get; set; }
        public List<AuthorVM> Authors { get; set; }
        public List<PublisherVM> Publishers { get; set; }
    }
}
