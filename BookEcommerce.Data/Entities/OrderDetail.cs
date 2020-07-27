﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }        
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

    }
}
