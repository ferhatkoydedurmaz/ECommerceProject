using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Entities;
using OrdersAPI.Services;
using System.Data.SqlTypes;
using System.Text.Json;

namespace OrdersAPI.Controllers;
[Route("api")]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("orders")]
    public async Task<IActionResult> Order([FromQuery] OrderFilterSearchKeys model)
    {
        var result = await _orderService.GetOrdersFilterAsync(model);
        //ContentResult contentResult = new ContentResult()
        //{
        //    Content = JsonSerializer.Serialize(result),
        //    ContentType = "application/json",
        //    StatusCode = 200
        //};
        return Ok(result);
    }
}
