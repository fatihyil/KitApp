using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEcommerce.Areas.Admin.Models
{
    public class AdminBookAddVM
    {
        //public int Id { get; set; }
        //public string Title { get; set; }       
        //public decimal Price { get; set; }
        //public string Description { get; set; }
        //public List<AdminAuthorVM> adminAuthors { get; set; }
        //public List<AdminCategoryVM> adminCategories { get; set; }
        //public List<AdminPublisherVM> adminPublishers { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public int BookPages { get; set; }
    }
}
