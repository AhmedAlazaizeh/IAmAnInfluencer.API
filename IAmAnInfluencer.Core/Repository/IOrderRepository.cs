using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IOrderRepository
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
        public bool clearCart(int ID);
        public List<userOrderListDTOResult> orderList(int ID);
        public object sumOfMyOrders(int ID);
        public List<InfluncersInfoDTOResult> getInfluncersInfo();
        public bool delivered(int ID);
        public bool notDelivered(int ID);
        public List<orderListDTOResult> influncerOrdersList(int ID);
        public object sumOfInfluncerRevune(int ID);
        public object sumOfInfluncerSales(int ID);
        public object countOfInfluncerOrders(int ID);
        public List<salesChartDTOResult> salesChart();
        public bool removeFromCart(removeFromCartDTO removeFromCartDTO);
    }
}
