﻿using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IProductRepository
    {
        public bool addProduct(AddProductDTO addProductDTO);
        public List<Product> getAllProduct();
        public bool deleteProduct(int ID);
        public bool updateProduct(AddProductDTO addProductDTO);
        public object countOfAvailableProducts();
        public List<Product> latestProducts();
        public List<Product> ProductPriceHighToLow();
        public List<Product> ProductPriceLowToHigh();
        public List<Product> getProduct(int ID);
        public List<Product> getMyProducts(int ID);
        public List<Product> latestProductsAll();
    }
}
