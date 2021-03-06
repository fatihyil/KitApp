﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
