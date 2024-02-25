using System;
using Microsoft.AspNetCore.SignalR;
using stockExchange.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace stockExchange.API.Hubs
{
    public class MessageHub : Hub<IMessageHubClient>
    {
        public async Task SendStocksToUser(IEnumerable<Stock> stocks)
        {

            await Clients.All.SendStocksToUser(stocks);
        }
    
    }
}

