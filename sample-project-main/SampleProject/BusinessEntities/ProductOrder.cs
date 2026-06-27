using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
    public class ProductOrder
    {
        public int ItemCount { get; set; }
        public Guid ProductId { get; set;  }
    }
}
