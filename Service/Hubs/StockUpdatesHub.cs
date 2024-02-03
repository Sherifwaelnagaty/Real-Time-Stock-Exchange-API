using Core.Domain;
using Core.Service;
using Microsoft.AspNetCore.SignalR;

namespace Stock_Exchange.Hubs
{
    public class StockUpdatesHub : Hub<IStockUpdatesHub>
    {
        public async Task SendStockUpdate(Stock updatedStock)
        {
            await Clients.All.SendStockUpdate(updatedStock);
        }
    }
}
