using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreBL;
using StoreBL.Models;
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

        public BlItem GetItemById(int? id)
        {
            if (id == null)
                throw new NullReferenceException();

            BlItem resultItem;

            using (var context = new DataContext())
            {
                resultItem = context.Items
                    .FirstOrDefault(item => item.ItemId == id).ToItemModel();
            }

            return resultItem;
        }
    }
}
