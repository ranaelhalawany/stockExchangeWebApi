using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stockExchange.API.Interfaces;
using stockExchange.API.Models;
using stockExchange.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using System.Security.Claims;
using stockExchange.API.Repositories;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace stockExchange.API.Controllers
{
    [Route("API/Orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;
        private readonly IStockService _stockService;

        //private readonly UserManager<User> _userManager;


        public OrderController(IOrderService OrderService, IStockService stockService) { 
            _OrderService = OrderService;
            _stockService = stockService;
            //_userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            //var Orders = _OrderService.GetAllOrders();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var Orders = _OrderService.GetOrders(userId);

            return Ok(Orders);
        }


        [HttpPost("addOrder")]
        [Authorize]
        public IActionResult CreateOrder([FromBody] OrderRequestDto OrderRequest)
        {


            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (OrderRequest == null)
            {
                // Handle the case where OrderRequest is null
                return BadRequest("Invalid Order request.");
            }
            var stock =  _stockService.GetBySymbol(OrderRequest.Stock_symbol);

            if(stock == null)
            {
                return BadRequest("Invalid Symbol!");
            }


            var newOrder = _OrderService.CreateOrder(userId,OrderRequest);

            if (newOrder!=null)
            {
                return Ok(newOrder); // Return the created Order or relevant data
            }

            return BadRequest("Order Creation Failed!");
        }

     
    }
}

