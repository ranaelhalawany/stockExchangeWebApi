using System;
using stockExchange.API.Models;

namespace stockExchange.API.Dtos
{
    public class OrderRequestDto
    {
        public string Stock_symbol { get; set; }
        public string Order_type { get; set; }
        public int Quantity { get; set; }
        // Add other properties as needed
    }

}

