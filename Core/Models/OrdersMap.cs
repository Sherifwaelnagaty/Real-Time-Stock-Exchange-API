using Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OrdersMap
    {
        public OrdersMap(EntityTypeBuilder<Orders> entityBuilder)
        {
            entityBuilder.HasKey(t => t.StockSymbol);
            entityBuilder.Property(t => t.Quantity).IsRequired();
            entityBuilder.Property(t => t.OrderType).IsRequired();
        }
    }
}
