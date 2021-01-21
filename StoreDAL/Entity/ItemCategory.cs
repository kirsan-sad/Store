using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.Entity
{
    public class ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
