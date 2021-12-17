using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addOrder(addOrderDTO addOrderDTO)
        {
            return orderService.addOrder(addOrderDTO);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteOrder(int ID)
        {
            return orderService.deleteOrder(ID);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Order>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Order> getAllOrder()
        {
            return orderService.getAllOrder();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateOrder(Order order)
        {
            return orderService.updateOrder(order);
        }

        [HttpGet]
        [Route("cartList/{ID}")]
        [ProducesResponseType(typeof(List<CartListDTOResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CartListDTOResult> cartList(int ID)
        {
            return orderService.cartList(ID);
        }

        [HttpGet]
        [Route("countOfCart/{ID}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfCart(int ID)
        {
            return orderService.countOfCart(ID);
        }

        [HttpGet]
        [Route("countOfOrders")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfOrders()
        {
            return orderService.countOfOrders();
        }

        [HttpGet]
        [Route("ordersList")]
        [ProducesResponseType(typeof(List<orderListDTOResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<orderListDTOResult> ordersList()
        {
            return orderService.ordersList();
        }

        [HttpGet]
        [Route("sumOfCart/{ID}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object sumOfCart(int ID)
        {
            return orderService.sumOfCart(ID);
        }

        [HttpGet]
        [Route("sumOfRevune")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object sumOfRevune()
        {
            return orderService.sumOfRevune();
        }

        [HttpGet]
        [Route("sumOfSales")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object sumOfSales()
        {
            return orderService.sumOfSales();
        }
    }
}
