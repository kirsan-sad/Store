using System.Collections.Generic;

namespace BL
{
    public interface IRepository
    {
        ICollection<T> GetProductsByCategory<T>(string catalogCategory);
    }
}
