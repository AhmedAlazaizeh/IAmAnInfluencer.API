﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;

namespace IAmAnInfluencer.Infra.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private readonly IDbContext _dbContext;

        public OrderRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("@orderDate", order.orderDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@isOrder", order.isOrder, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@orderValue", order.orderValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", order.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", order.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
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
            p.Add("@orderValue", order.orderValue, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", order.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", order.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateOrder", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
