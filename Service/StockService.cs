using Core.Domain;
using Core.Repository;
using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Stock_Exchange.Hubs;


namespace Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository<Stock> _stockRepository;
        private readonly IHubContext<StockUpdatesHub, IStockUpdatesHub> _hubContext;

        public StockService(IStockRepository<Stock> stockRepository, IHubContext<StockUpdatesHub, IStockUpdatesHub> hubContext) 
        {
            _stockRepository = stockRepository;
            _hubContext = hubContext;
        }
        public IEnumerable<Stock> GetStockData(int pageNumber, int pageSize)
        {
            return _stockRepository.GetStockData(pageNumber,pageSize);
        }
        public IEnumerable<Stock> GetStockHistory(string Symbol)
        {
            return _stockRepository.GetStockHistory(Symbol);
        }
        public void UpdateStockPrice(string symbol, decimal newPrice)
        {
            _stockRepository.UpdateStockPrice(symbol, newPrice);
        }
    }
}
