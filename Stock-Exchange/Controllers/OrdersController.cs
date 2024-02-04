using Microsoft.AspNetCore.Mvc;
using Repository;
using Service;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Core.Domain;
using Core.Service;
namespace StockExchange.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderRepository;
    public OrdersController(IOrderService orderRepository)
    {
        _orderRepository = orderRepository;
    }
    [HttpPost("orders")]
    public ActionResult<Orders> CreateOrder([FromBody] Orders order)
    {
        return _orderRepository.CreateOrder(order);
    }
    [HttpGet("orders")]
    public IEnumerable<Orders> GetOrderHistory(string symbol)
    {
        return _orderRepository.GetOrderHistory(symbol);
    }
}