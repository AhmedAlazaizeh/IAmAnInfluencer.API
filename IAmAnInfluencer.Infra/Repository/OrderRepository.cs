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
    public class OrderRepository: IOrderRepository
    {
        private readonly IDbContext _dbContext;

        public OrderRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addOrder(addOrderDTO addOrderDTO)
        {
            var p = new DynamicParameters();
            p.Add("@isOrder", addOrderDTO.isOrder, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@orderValue", addOrderDTO.orderValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", addOrderDTO.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", addOrderDTO.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@isDelivered", addOrderDTO.isDelivered, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Order> getAllOrder()
        {
            var p = new DynamicParameters();
            IEnumerable<Order> result = _dbContext.Connection.Query<Order>("getAllOrder", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteOrder(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@orderID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("@orderID", order.orderID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@orderDate", order.orderDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@isOrder", order.isOrder, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@isDelivered", order.isDelivered, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@orderValue", order.orderValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", order.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", order.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<CartListDTOResult> cartList(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CartListDTOResult> result = _dbContext.Connection.Query<CartListDTOResult>("cartList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public object countOfCart(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfCart", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public object countOfOrders()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfOrders", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public List<orderListDTOResult> ordersList()
        {
            var p = new DynamicParameters();
            IEnumerable<orderListDTOResult> result = _dbContext.Connection.Query<orderListDTOResult>("ordersList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public object sumOfCart(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            object result = _dbContext.Connection.QueryFirstOrDefault("sumOfCart", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public object sumOfRevune()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("sumOfRevune", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public object sumOfSales()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("sumOfSales", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool clearCart(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("clearCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<userOrderListDTOResult> orderList(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<userOrderListDTOResult> result = _dbContext.Connection.Query<userOrderListDTOResult>("orderList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public object sumOfMyOrders(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            object result = _dbContext.Connection.QueryFirstOrDefault("sumOfMyOrders", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
