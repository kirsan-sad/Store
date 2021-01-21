using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataModels
{
    public class ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
