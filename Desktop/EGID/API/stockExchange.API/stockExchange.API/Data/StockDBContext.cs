using System;
using Microsoft.EntityFrameworkCore;
using stockExchange.API.Models;

namespace stockExchange.API.Data
{
    public class StockDBContext : DbContext
    {

        public StockDBContext(DbContextOptions<StockDBContext> options) : base(options) { }

        public DbSet<Models.Stock> Stock { get; set; }
        public DbSet<Models.StockHistory> Stock_history { get; set; }
        public DbSet<Models.Order> Orders { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Stock>()
        //        .HasMany(stock => stock.StockHistories)
        //        .WithOne(stockHistory => stockHistory.Stock)
        //        .HasForeignKey(stockHistory => stockHistory.Id);

        //    // Additional configurations...

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}

 