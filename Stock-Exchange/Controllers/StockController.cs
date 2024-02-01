using Core.Domain;
using Core.Models;
using Core.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Algoriza_Project_2023BE83.Controllers
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
        public IEnumerable<Stock> GetStockData()
        {
            return _stockService.GetStockData();
        }
        [HttpGet("stocks/{symbol}/history")]
        public IEnumerable<Stock> GetStockHistory(string symbol)
        {
            return _stockService.GetStockHistory(symbol);
        }
    }
}
