using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    [AutoRegister]
    public class ProductRepository: WebRepository<Product>, IProductRepository
    {
        public ProductRepository() { }

        public IEnumerable<Product> Get(ProductType? type = null)
        {
            if(type != null)
            {
                return GetAll().Where(x => x.Type == type);
            }

            return null;
        }
    }
}
