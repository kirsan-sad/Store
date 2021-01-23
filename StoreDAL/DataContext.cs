using Microsoft.EntityFrameworkCore;
using StoreDAL.Entity;
using System;

namespace StoreDAL
{
    public class DataContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategoryes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Storedb;Integrated Security=True");
        }
    }
}
