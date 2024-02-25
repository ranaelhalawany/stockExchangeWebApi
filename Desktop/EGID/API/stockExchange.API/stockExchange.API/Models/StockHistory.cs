using System;
namespace stockExchange.API.Models
{
    public class StockHistory
    {
        public int Id { get; set; }
        public int Stock_id { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
        public StockHistory()
        {
        }
    }
}

