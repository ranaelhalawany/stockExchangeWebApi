using stockExchange.API.Dtos;
using stockExchange.API.Interfaces;
using stockExchange.API.Models;
using stockExchange.API.Repositories;
using System.Collections.Generic;

namespace stockExchange.API.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IStockHistoryRepository _stockHistoryRepository;

        public StockService(IStockRepository stockRepository, IStockHistoryRepository stockHistoryRepository)
        {
            _stockRepository = stockRepository;
            _stockHistoryRepository = stockHistoryRepository;
        }

        public IEnumerable<Stock> GetAllStocks()
        {
            return _stockRepository.GetAll();
        }

        public Stock GetBySymbol(string symbol)
        {
            return _stockRepository.GetBySymbol(symbol);
        }

        public IEnumerable<StockHistory> GetStockHistory(string symbol)
        {
            // You can implement the logic to retrieve historical stock data from the repository
         return _stockHistoryRepository.GetStockHistory(symbol);

            // Map the data to DTOs if necessary
        
        }
    }
}
