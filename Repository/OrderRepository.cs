using Core.Domain;
using Core.Models;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Repository.Data;
using System;
using System.Threading.Tasks;

namespace Repository;
public class OrdersRepository<T> : IOrderRepository<T> where T : Orders
{
    private readonly ApplicationContext _context;
    private DbSet<T> entities;
    public OrdersRepository(ApplicationContext context)
    {
        _context = context;
        entities = context.Set<T>();
    }
    public T CreateOrder(T Model)
    {
        if (Model != null)
        {
            entities.Add(Model);
            _context.SaveChangesAsync();
            return Model;
        }
        else
        {
            throw new Exception("There's something wrong in your Input try again");
        }
    }
    public IEnumerable<T> GetOrdersHistory(string symbol)
    {
        return entities.Where(orders => orders.StockSymbol == symbol);
    }
}