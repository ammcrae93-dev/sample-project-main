using BusinessEntities;
using Common;
using Core.Factories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Products
{
    [AutoRegister]
    public class CreateProductService : ICreateProductService
    {
        private readonly IUpdateProductService _updateProductService;
        private readonly IIdObjectFactory<Product> _productFactory;
        private readonly IProductRepository _productRepository;

        public CreateProductService(IIdObjectFactory<Product> productFactory, IProductRepository productRepository, IUpdateProductService updateProductService)
        {
            _productFactory = productFactory;
            _productRepository = productRepository;
            _updateProductService = updateProductService;
        }

        public Product Create(Guid productId, string name, decimal price, ProductType type, int stock)
        {
            var product = _productFactory.Create(productId);
            _updateProductService.Update(product, name, price, type, stock);
            _productRepository.Save(product);
            return product;
        }
    }
}
