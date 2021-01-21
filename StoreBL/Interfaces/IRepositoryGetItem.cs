using System.Collections.Generic;

namespace StoreBL
{
    public interface IRepositoryGetItem<T> where T:class
    {
        ICollection<T> GetItemByCategory(string categoryName);
    }
}
