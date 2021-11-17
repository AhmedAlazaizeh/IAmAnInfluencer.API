using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IOrderRepository
    {
        public bool addOrder(Order order);
        public List<Order> getAllOrder();
        public bool deleteOrder(int ID);
        public bool updateOrder(Order order);
    }
}
