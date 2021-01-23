using Microsoft.EntityFrameworkCore;
using StoreBL;
using StoreDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDAL.Repositories
{
    public class EFCoreRepositoryGetItem : IRepositoryGetItem<Item>
    {
        public ICollection<Item> GetItemByCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                throw new NullReferenceException();

            ICollection<Item> resultItems;

            using (var context = new DataContext())
            {
                resultItems = context.ItemCategoryes
                    .Where(category => category.Name == categoryName)
                    .SelectMany(items => items.Items)
                    .ToList();
            }

            return resultItems;
        }
    }
}
