using BusinessEntities;
using Common;
using System.Collections.Generic;

namespace Core.Services.Products
{
    [AutoRegister(AutoRegisterTypes.Singleton)]
    public class UpdateProductService : IUpdateProductService
    {
        public void Update(Product product, string name, decimal price, ProductType type, int stock, string sku)
        {
            product.SetName(name);
            product.SetPrice(price);
            product.SetType(type);
            product.SetStock(stock);
            product.SetSku(sku);
        }
    }
}
