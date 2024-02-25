using System;
namespace stockExchange.API.Dtos
{
    public class StockHistoryDto
    {
        public DateTime Timestamp { get; set; }
        public decimal Price { get; set; }
        public StockHistoryDto()
        {
        }
    }
}

