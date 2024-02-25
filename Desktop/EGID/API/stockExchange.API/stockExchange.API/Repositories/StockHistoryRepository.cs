using System;
using stockExchange.API.Data;
using stockExchange.API.Dtos;
using stockExchange.API.Models;
using Microsoft.EntityFrameworkCore;


namespace stockExchange.API.Repositories
{

    public class StockHistoryRepository : IStockHistoryRepository
    {
        private readonly StockDBContext _context;

        public StockHistoryRepository(StockDBContext context)
        {
            _context = context;
        }

        public IEnumerable<StockHistory> GetStockHistory(string symbol)
        {
            // Get the Stock entity based on the provided symbol
            var stock = _context.Stock
                .FirstOrDefault(s => s.Symbol == symbol);

            if (stock == null)
            {
                // Handle the case where no stock is found for the provided symbol
                return new List<StockHistory>();
            }

            // Retrieve StockHistories associated with the found Stock
            return _context.Stock_history
            .Where(sh => sh.Stock_id == stock.Id)
            .OrderByDescending(sh => sh.Timestamp);

        }

      
    }

}

