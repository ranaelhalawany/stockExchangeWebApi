using System;
namespace stockExchange.API.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Company { get; set;}
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }


        public Stock()
        {
        }
    }
}

