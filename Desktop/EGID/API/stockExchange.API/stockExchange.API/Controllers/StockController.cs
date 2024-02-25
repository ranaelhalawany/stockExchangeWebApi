using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using stockExchange.API.Interfaces;
using stockExchange.API.Models;
using stockExchange.API.Services;
using System.Collections.Generic;

namespace StockExchange.API.Controllers
{
    [Route("API/stocks")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Stock>> GetAllStocks()
        {
            var stocks = _stockService.GetAllStocks();
            return Ok(stocks);
        }

        [HttpGet("{symbol}/history")]
        [Authorize]
        public async Task<IActionResult> GetStockHistory(string symbol)
        {
            try
            {
                var stockHistory =  _stockService.GetStockHistory(symbol);
                return Ok(stockHistory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }


}
