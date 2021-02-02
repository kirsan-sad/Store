using StoreBL.Models;
using StoreDAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL
{
    internal static class EntitiesToModelsConverter
    {
        internal static BlItem ToItemModel(this Item itemEntity)
        {
            return new BlItem()
            {
                Index = itemEntity.ItemId,
                Name = itemEntity.Name,
                Description = itemEntity.Description,
                Price = itemEntity.Price
            };
        }
    }
}
