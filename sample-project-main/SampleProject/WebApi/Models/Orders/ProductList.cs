using BusinessEntities;
using System;
using System.Collections.Generic;

namespace WebApi.Models.Orders
{
    public class ProductList
    {
        public List<Guid> ProductIds { get; set; }
    }
}