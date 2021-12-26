using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.DTO;

namespace IAmAnInfluencer.Infra.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly IDbContext _dbContext;

        public ProductRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addProduct(AddProductDTO addProductDTO)
        {
            var p = new DynamicParameters();
            p.Add("@price", addProductDTO.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@description", addProductDTO.description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@productTitle", addProductDTO.productTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@image", addProductDTO.image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isAvailable", addProductDTO.isAvailable, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", addProductDTO.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@categoryID", addProductDTO.categoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Product> getAllProduct()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("getAllProduct", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteProduct(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@productID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateProduct(AddProductDTO addProductDTO)
        {
            var p = new DynamicParameters();
            p.Add("@productID", addProductDTO.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@price", addProductDTO.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@description", addProductDTO.description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@productTitle", addProductDTO.productTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@image", addProductDTO.image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isAvailable", addProductDTO.isAvailable, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", addProductDTO.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@categoryID", addProductDTO.categoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public object countOfAvailableProducts()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfAvailableProducts", p, commandType: CommandType.StoredProcedure);
            return result;
        }
        public List<Product> latestProducts()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("latestProducts", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<Product> ProductPriceHighToLow()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPriceHighToLow", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<Product> ProductPriceLowToHigh()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("ProductPriceLowToHigh", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<getAProductDTOResult> getProduct(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@productID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<getAProductDTOResult> result = _dbContext.Connection.Query<getAProductDTOResult>("getProduct", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Product> getMyProducts(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("getMyProducts", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Product> latestProductsAll()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("latestProductsAll", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Product> searchProduct(string searchedFor)
        {
            var p = new DynamicParameters();
            p.Add("@searchedFor", searchedFor, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("searchProduct", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
