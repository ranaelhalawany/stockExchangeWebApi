using System;
using stockExchange.API.Models;


namespace stockExchange.API.Hubs
{
    public interface IMessageHubClient
    {
        Task SendStocksToUser(IEnumerable<Stock> stocks);


    }
}

