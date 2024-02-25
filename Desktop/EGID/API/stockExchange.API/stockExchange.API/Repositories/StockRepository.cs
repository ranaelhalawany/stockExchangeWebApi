using System;
using Microsoft.EntityFrameworkCore;
using stockExchange.API.Data;
using stockExchange.API.Models;
namespace stockExchange.API.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly StockDBContext _context;

        public StockRepository(StockDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Stock> GetAll()
        {
            return _context.Stock.ToList();
        }

        public  Stock GetBySymbol(string symbol)
        {
            return  _context.Stock.FirstOrDefault(s => s.Symbol == symbol);

        }
    }
}

