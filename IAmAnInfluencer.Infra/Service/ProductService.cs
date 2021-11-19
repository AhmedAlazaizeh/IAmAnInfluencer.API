using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public bool addProduct(Product product)
        {
            return productRepository.addProduct(product);
        }

        public bool deleteProduct(int ID)
        {
            return productRepository.deleteProduct(ID);
        }

        public List<Product> getAllProduct()
        {
            return productRepository.getAllProduct();
        }

        public bool updateProduct(Product product)
        {
            return productRepository.updateProduct(product);
        }

        public int countOfAvailableProducts()
        {
            return productRepository.countOfAvailableProducts();
        }

        public List<Product> latestProducts()
        {
            return productRepository.latestProducts();
        }

        public List<Product> ProductPriceHighToLow()
        {
            return productRepository.ProductPriceHighToLow();
        }
        public List<Product> ProductPriceLowToHigh()
        {
            return productRepository.ProductPriceLowToHigh();
        }
    }
}
