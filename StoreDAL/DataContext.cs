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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Item>().HasData(new Item { ItemId = 1, Name = "Apple Iphone 7", ShortDescription = "Short Description", FullDescription = "Full Description Apple Iphone 7", Price = 900});
        //    modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory { ItemCategoryId = 1, CategoryName = "Phone"});
        //}
    }
}
