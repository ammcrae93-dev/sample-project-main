using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    [AutoRegister]
    public class OrderRepository : WebRepository<Order>, IOrderRepository
    {
        public OrderRepository() { }

        public IEnumerable<Order> GetByProducts(List<Guid> products = null)
        {
            List<Order> filteredOrders = new List<Order>();
            List<Order> allOrders = GetAll().ToList();

            if(products == null)
            {
                return allOrders;
            }

            if(allOrders.Any())
            {
                foreach (var product in products)
                {
                    filteredOrders.AddRange(allOrders.Where(x => x.Products.Any(item => item.ProductId == product)));
                }
            }

            return filteredOrders;
        }
    }
}
