using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    using Core.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Core.Models;

    namespace Repository.Data
    {
        public class ApplicationContext : IdentityDbContext<User>
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
            {

            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                new StockMap(modelBuilder.Entity<Stock>());
                new OrdersMap(modelBuilder.Entity<Orders>());
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}