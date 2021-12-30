using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }

        public bool addOrder(addOrderDTO addOrderDTO)
        {
            return orderRepository.addOrder(addOrderDTO);
        }

        public bool deleteOrder(int ID)
        {
            return orderRepository.deleteOrder(ID);
        }

        public List<Order> getAllOrder()
        {
            return orderRepository.getAllOrder();
        }

        public bool updateOrder(Order order)
        {
            return orderRepository.updateOrder(order);
        }

        public List<CartListDTOResult> cartList(int ID)
        {
            return orderRepository.cartList(ID);
        }

        public object countOfCart(int ID)
        {
            return orderRepository.countOfCart(ID);
        }

        public object countOfOrders()
        {
            return orderRepository.countOfOrders();
        }

        public List<orderListDTOResult> ordersList()
        {
            return orderRepository.ordersList();
        }

        public object sumOfCart(int ID)
        {
            return orderRepository.sumOfCart(ID);
        }

        public object sumOfRevune()
        {
            return orderRepository.sumOfRevune();
        }

        public object sumOfSales()
        {
            return orderRepository.sumOfSales();
        }

        public bool clearCart(int ID)
        {
            return orderRepository.clearCart(ID);
        }

        public List<userOrderListDTOResult> orderList(int ID)
        {
            return orderRepository.orderList(ID);
        }
        public object sumOfMyOrders(int ID)
        {
            return orderRepository.sumOfMyOrders(ID);
        }
        public List<InfluncersInfoDTOResult> getInfluncersInfo()
        {
            return orderRepository.getInfluncersInfo();
        }

        public bool delivered(int ID)
        {
            return orderRepository.delivered(ID);
        }

        public bool notDelivered(int ID)
        {
            return orderRepository.notDelivered(ID);
        }

        public List<orderListDTOResult> influncerOrdersList(int ID)
        {
            return orderRepository.influncerOrdersList(ID);
        }

        public object sumOfInfluncerRevune(int ID)
        {
            return orderRepository.sumOfInfluncerRevune(ID);
        }

        public object sumOfInfluncerSales(int ID)
        {
            return orderRepository.sumOfInfluncerSales(ID);
        }

        public object countOfInfluncerOrders(int ID)
        {
            return orderRepository.countOfInfluncerOrders(ID);
        }

        public List<salesChartDTOResult> salesChart()
        {
            return orderRepository.salesChart();
        }
    }
}
