using Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class StockMap
    {
        public StockMap(EntityTypeBuilder<Stock> entityBuilder)
        {
            entityBuilder.HasKey(t => t.StockSymbol);
            entityBuilder.Property(t => t.Timestamps).IsRequired();
            entityBuilder.Property(t => t.Currentprices).IsRequired();
        }
    }
}
