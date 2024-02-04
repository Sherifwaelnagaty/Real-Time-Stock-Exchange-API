using Core.Domain;
using Core.Models;
using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace StockExchange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController:ControllerBase
    {
        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }
        [HttpGet("stocks")]
        public IEnumerable<Stock> GetStockData(int pageNumber, int pageSize)
        {
            return _stockService.GetStockData(pageNumber,pageSize);
        }
        [HttpGet("stocks/{symbol}/history")]
        public IEnumerable<Stock> GetStockHistory(string symbol)
        {
            return _stockService.GetStockHistory(symbol);
        }
    }
}
