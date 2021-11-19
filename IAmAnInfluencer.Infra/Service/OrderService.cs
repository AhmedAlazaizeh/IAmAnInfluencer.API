using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }

        public bool addOrder(Order order)
        {
            return orderRepository.addOrder(order);
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

        public List<Order> cartList(int ID)
        {
            return orderRepository.cartList(ID);
        }

        public int countOfCart(int ID)
        {
            return orderRepository.countOfCart(ID);
        }

        public int countOfOrders()
        {
            return orderRepository.countOfOrders();
        }

        public List<Order> ordersList()
        {
            return orderRepository.ordersList();
        }

        public Double sumOfCart(int ID)
        {
            return orderRepository.sumOfCart(ID);
        }

        public Double sumOfRevune()
        {
            return orderRepository.sumOfRevune();
        }

        public Double sumOfSales()
        {
            return orderRepository.sumOfSales();
        }
    }
}
