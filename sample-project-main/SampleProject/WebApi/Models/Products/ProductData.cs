using BusinessEntities;
using System;

namespace WebApi.Models.Products
{
    public class ProductData : IdObjectData
    {
        public ProductData(Product product) : base(product)
        {
            Name = product.Name;
            Price = Math.Round(product.Price, 2);
            Type = new EnumData(product.Type);
            Stock = product.Stock;
            Sku = product.Sku;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public EnumData Type { get; set; }
        public int Stock { get; set; }
        public string Sku { get; set; }
    }
}