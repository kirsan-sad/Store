using System;
using System.Collections.Generic;
using System.Linq;
using BL;
using Microsoft.AspNetCore.Mvc;

namespace DAL
{
    public class RepositoryEF : IRepository
    {
        public ICollection<Item> GetProductsByCategory<Item>(string catalogCategory)
        {
            ICollection<Item> result = null;

            if (string.IsNullOrEmpty(catalogCategory))
                throw new ArgumentNullException();

            using (var db = new DataContext())
            {
                var allitemCategory = db.ItemCategory.ToList();
                var items = db.Item.ToList();
                //var itemsCategorys = db.

                //switch (catalogCategory)
                //{
                //    case "Cameras":
                //        var query = from item in allItems
                //                    join cat in allItemsInCategoryes on item.ItemCategories equals cat.Items
                //                    where cat.CategoryName == catalogCategory
                //                    //join prod in products on catalogProduct.ProductId equals prod.Id
                //                    select item;
                //        //result = allItemsInCategoryes.Where(c => c.CategoryName.Contains(catalogCategory)).Select(c);
                //        break;
                //    case "Headphones":
                //        result = db.Cameras.ToList();
                //        break;
                //    default:
                //        break;
                //}
            }

            return result;
        }
    }
}
