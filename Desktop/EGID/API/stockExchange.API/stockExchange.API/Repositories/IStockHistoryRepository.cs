using System;
using stockExchange.API.Models;

namespace stockExchange.API.Repositories
{
    public interface IStockHistoryRepository
    {
        IEnumerable<StockHistory> GetStockHistory(string symbol);

    }
}

