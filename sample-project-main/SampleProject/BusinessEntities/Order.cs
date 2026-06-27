using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Order: IdObject
    {
        private Guid _userId;
        private IEnumerable<ProductOrder> _products;

        public Guid UserId
        {
            get => _userId;
            private set => _userId = value;
        }

        public IEnumerable<ProductOrder> Products
        {
            get => _products;
            private set => _products = value;
        }

        public void SetUserId(Guid userId)
        {
            _userId = userId;
        }

        public void SetProducts(IEnumerable<ProductOrder> products)
        {
            _products = products;
        }
    }
}
