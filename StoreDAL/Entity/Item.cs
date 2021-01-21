using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.Entity
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; }
    }
}
