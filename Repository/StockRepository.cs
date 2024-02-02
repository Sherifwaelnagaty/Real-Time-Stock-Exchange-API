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
        public IEnumerable<T> GetStockData(int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
            {
                throw new ArgumentException("Page number should be greater than or equal to 1.", nameof(pageNumber));
            }
            if (pageSize < 1)
            {
                throw new ArgumentException("Page size should be greater than or equal to 1.", nameof(pageSize));
            }
            // Calculate the number of items to skip
            int itemsToSkip = (pageNumber - 1) * pageSize;

            // Use Skip and Take for pagination
            return entities.Skip(itemsToSkip).Take(pageSize).AsEnumerable();
        }
        public IEnumerable<T> GetStockHistory(string symbol)
        {
            return entities.Where(stock => stock.StockSymbol == symbol);
        }
    }
}
