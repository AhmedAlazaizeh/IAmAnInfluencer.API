using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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

        public bool addProduct(AddProductDTO addProductDTO)
        {
            return productRepository.addProduct(addProductDTO);
        }

        public bool deleteProduct(int ID)
        {
            return productRepository.deleteProduct(ID);
        }

        public List<Product> getAllProduct()
        {
            return productRepository.getAllProduct();
        }

        public bool updateProduct(AddProductDTO addProductDTO)
        {
            return productRepository.updateProduct(addProductDTO);
        }

        public object countOfAvailableProducts()
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

        public List<getAProductDTOResult> getProduct(int ID)
        {
            return productRepository.getProduct(ID);
        }

        public List<Product> getMyProducts(int ID)
        {
            return productRepository.getMyProducts(ID);
        }

        public List<Product> latestProductsAll()
        {
            return productRepository.latestProductsAll();
        }

        public List<Product> searchProduct(string searchedFor)
        {
            return productRepository.searchProduct(searchedFor);
        }
    }
}
