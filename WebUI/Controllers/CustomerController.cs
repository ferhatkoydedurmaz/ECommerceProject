using Business.Abstract;
using Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[Route("customer")]
public class CustomerController : Controller
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("/customer")]
    public async Task<IActionResult> Customer()
    {
        var result = await _customerService.GetCustomersAsync();

        if (result.Success == false)
            return new BadRequestObjectResult(result);

        return View(model: result);
    }

    [HttpPost("/customer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddCustomer([FromForm] CustomerDto model)
    {
        var result = await _customerService.AddCustomerAsync(model);

        if (result.Success == false)
            return new BadRequestObjectResult(result);

        return RedirectToAction("Customer");

    }
}
