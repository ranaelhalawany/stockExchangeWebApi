using System;
namespace stockExchange.API.Models
{
    public class Order
    {
        
            public int Id { get; set; }
            public string User_id { get; set; }
            public int Quantity { get; set; }
            public string Stock_symbol { get; set; }
            public DateTime Timestamp { get; set; }
            public string Order_type { get; set; }
        
         
    }
 
}

