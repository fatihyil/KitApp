using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public string BookImageUrl { get; set; }
        public int BookPages { get; set; }
        public decimal Price { get; set; }
        public int? StockCount { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<OrderDetail> orderDetails { get; set; }

    }
}
