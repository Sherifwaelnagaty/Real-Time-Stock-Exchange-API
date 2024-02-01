using Core.Domain;
using Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IStockService
    {
        IEnumerable<Stock> GetStockHistory(string Symbol);
        IEnumerable<Stock> GetStockData();
    }
}
