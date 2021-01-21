using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataModels
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int Price { get; set; }
        public ICollection<ItemCategory> ItemCategories { get; set; }
    }
}
