using BusinessEntities;
using System;
using System.Collections.Generic;

namespace WebApi.Models.Orders
{
    public class OrderData : IdObjectData
    {
        public OrderData(Order order) : base(order)
        {
            UserId = order.UserId;
            Products = order.Products;
        }

        public Guid UserId { get; set; }
        public IEnumerable<ProductOrder> Products { get; set; }
    }
}