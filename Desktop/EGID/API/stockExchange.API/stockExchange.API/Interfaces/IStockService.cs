using System;
using stockExchange.API.Dtos;
using stockExchange.API.Models;

namespace stockExchange.API.Interfaces
{
    public interface IStockService
    {
        IEnumerable<Stock> GetAllStocks();
        IEnumerable<StockHistory> GetStockHistory(string symbol);
        Stock GetBySymbol(string symbol);


    }
}

