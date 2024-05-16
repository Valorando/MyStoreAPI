using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStoreAPI.Interfaces;
using MyStoreAPI.Models;

namespace MyStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrderService orderService, ILogger<OrdersController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderModel orderModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _logger.LogInformation($"Client send new order: OrderId={orderModel.OrderId}, OrderDate={orderModel.OrderDate}, FirstName={orderModel.FirstName}, SecondName={orderModel.SecondName}, PhoneNumber={orderModel.PhoneNumber}, ProductName={orderModel.ProductName}, Amount={orderModel.Amount}");

                await _orderService.AddOrder(orderModel);

                return CreatedAtAction(nameof(Post), null);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
