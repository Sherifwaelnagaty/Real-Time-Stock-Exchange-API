using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IStockRepository<T> where T : Stock
    {
        IEnumerable<T> GetStockHistory(string Symbol);
        IEnumerable<T> GetStockData(int pageNumber, int pageSize);
        void UpdateStockPrice(string symbol, decimal newPrice);

    }
}