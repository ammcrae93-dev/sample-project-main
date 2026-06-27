using BusinessEntities;
using System;

namespace WebApi.Models.Products
{
    public class ProductModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public int Stock { get; set; }
        public string Sku { get; set; }
    }
}