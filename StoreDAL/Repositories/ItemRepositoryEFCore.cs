using Microsoft.EntityFrameworkCore;
using StoreBL;
using StoreDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDAL.Repositories
{
    public class ItemRepositoryEFCore : IRepositoryGetItem<Item>
    {
        private readonly DbContextOptions<DataContext> _dbContextOptios;

        public ItemRepositoryEFCore(DbContextOptions<DataContext> dbContextOptios)
        {
            _dbContextOptios = dbContextOptios;
        }

        public ICollection<Item> GetItemByCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                throw new NullReferenceException();

            ICollection<Item> resultItems;

            using (var context = new DataContext(_dbContextOptios))
            {
                resultItems = context.Items
                    .Include(c => c.ItemCategories)
                    .ThenInclude(cat => cat.Name == categoryName)
                    .ToList();
            }

            return resultItems;
        }
    }
}
