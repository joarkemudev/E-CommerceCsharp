using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Services;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService.Services.OrderService _orderService;

        public OrdersController(OrderService.Services.OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return _orderService.GetOrders();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(string id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpPost]
        public ActionResult<Order> AddOrder(Order order)
        {
            _orderService.AddOrder(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(string id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            var existingOrder = _orderService.GetOrderById(id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            _orderService.UpdateOrder(order);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(string id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            _orderService.DeleteOrder(id);
            return NoContent();
        }
    }
}