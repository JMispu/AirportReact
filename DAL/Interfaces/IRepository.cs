using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IRepository<T>
    {
        Task<List<T>> GetList();
        Task<T> GetItem(int id);
        Task<T> CreateItem(T item);
        Task DeleteItem(int id);
        void UpdateItem(T item);
    }
}
