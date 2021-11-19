﻿using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IOrderService
    {
        public bool addOrder(Order order);
        public List<Order> getAllOrder();
        public bool deleteOrder(int ID);
        public bool updateOrder(Order order);
        public List<Order> cartList(int ID);
        public int countOfCart(int ID);
        public int countOfOrders();
        public List<Order> ordersList();
        public Double sumOfCart(int ID);
        public Double sumOfRevune();
        public Double sumOfSales();
    }
}
