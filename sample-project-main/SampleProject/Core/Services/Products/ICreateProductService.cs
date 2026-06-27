using System;
using System.Collections.Generic;
using System.Text;
using BusinessEntities;

namespace Core.Services.Products
{
    public interface ICreateProductService 
    { 
    
        Product Create (Guid productId, string name, decimal price, ProductType type, int stock);
    }
}
