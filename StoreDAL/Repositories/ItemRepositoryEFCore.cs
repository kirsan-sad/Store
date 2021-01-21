using StoreBL;
using StoreDAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.Repositories
{
    public class ItemRepositoryEFCore : IRepositoryGetItem<Item>
    {
        public ICollection<Item> GetItemByCategory(string categoryName)
        {
            using (resource)
            {

            }
        }
    }
}
