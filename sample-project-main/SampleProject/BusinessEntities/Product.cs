using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BusinessEntities
{
    public class Product: IdObject
    {
        private string _name;
        private decimal _price;
        private ProductType _type = ProductType.Clothing;
        private int _stock;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public decimal Price
        {
            get => _price;
            private set => _price = value;
        }

        public ProductType Type
        {
            get => _type;
            private set => _type = value;
        }

        public int Stock
        {
            get => _stock;
            private set => _stock  = value;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name was not provided.");
            }
            _name = name;
        }

        public void SetPrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentNullException("Price cannot be negative.");
            }
            _price = price;
        }

        public void SetType(ProductType type)
        {
            _type = type;
        }

        public void SetStock(int stock)
        {
            _stock = stock;
        }
    }
}
