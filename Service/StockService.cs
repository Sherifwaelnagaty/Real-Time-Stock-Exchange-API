using Core.Domain;
using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository<Stock> _stockRepository;
        public StockService(IStockRepository<Stock> stockRepository) 
        {
            _stockRepository = stockRepository;
        }
        public IEnumerable<Stock> GetStockData()
        {
            return _stockRepository.GetStockData();
        }
        public IEnumerable<Stock> GetStockHistory(string Symbol)
        {
            return _stockRepository.GetStockHistory(Symbol);
        }
    }
}
