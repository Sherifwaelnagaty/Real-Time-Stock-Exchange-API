using Core.Domain;
using System.Threading.Tasks;

namespace Core.Repository;
public interface IOrderRepository<T> where T : Orders 
{
    T CreateOrder(T couponModel);
    IEnumerable<T> GetOrdersHistory(string symbol);
}