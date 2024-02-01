using Core.Domain;
using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Data.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StockRepository<T>: IStockRepository<T> where T: Stock
    {
        private readonly ApplicationContext _context;
        private DbSet<T> entities;
        public StockRepository(ApplicationContext context) 
        {
            _context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetStockData()
        {
        
        }

        public IEnumerable<T> GetStockHistory(string symbol)
        {
            return entities.Where(stock => stock.StockSymbol == symbol);
        }
    }
}
