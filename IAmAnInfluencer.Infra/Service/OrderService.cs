using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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
    }
}
