using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister(AutoRegisterTypes.Singleton)]
    public class UpdateOrderService
    {
        public void Update(Order order, Guid userId, IEnumerable<ProductOrder> products)
        {
            order.SetUserId(userId);
            order.SetProducts(products);
        }
    }
}
