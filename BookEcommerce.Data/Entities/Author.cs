using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual ICollection<Book> Books { get; set; } 
    }
}
