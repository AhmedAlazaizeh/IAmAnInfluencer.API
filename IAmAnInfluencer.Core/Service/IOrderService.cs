﻿using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IOrderService
    {
        public bool addOrder(addOrderDTO addOrderDTO);
        public List<Order> getAllOrder();
        public bool deleteOrder(int ID);
        public bool updateOrder(Order order);
        public List<CartListDTOResult> cartList(int ID);
        public object countOfCart(int ID);
        public object countOfOrders();
        public List<orderListDTOResult> ordersList();
        public object sumOfCart(int ID);
        public object sumOfRevune();
        public object sumOfSales();
    }
}
