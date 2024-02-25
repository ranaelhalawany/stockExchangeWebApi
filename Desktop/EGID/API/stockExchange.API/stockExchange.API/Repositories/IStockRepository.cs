using System;
using stockExchange.API.Models;

namespace stockExchange.API.Repositories
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetAll();
        Stock GetBySymbol(string symbol);


    }
}

