using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IProductService
    {
        public bool addProduct(Product product);
        public List<Product> getAllProduct();
        public bool deleteProduct(int ID);
        public bool updateProduct(Product product);
        public int countOfAvailableProducts();
        public List<Product> latestProducts();
        public List<Product> ProductPriceHighToLow();
        public List<Product> ProductPriceLowToHigh();
    }
}
