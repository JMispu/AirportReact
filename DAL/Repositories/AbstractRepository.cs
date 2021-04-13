using DAL.Context;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AbstractRepository<T> : IRepository<T> where T : class
    {
        protected AirportContext DB;
        protected DbSet<T> DBset;

        public AbstractRepository(DbSet<T> dbset, AirportContext db)
        {
            DBset = dbset;
            DB = db;
        }

        public async Task<T> CreateItem(T item)
        {
            return (await DBset.AddAsync(item)).Entity;
        }

        public async Task DeleteItem(int id)
        {
            T m = await DBset.FindAsync(id);
            DBset.Remove(m);
        }

        public async Task<T> GetItem(int id)
        {
            return await DBset.FindAsync(id);
        }

        public async Task<List<T>> GetList()
        {
            return await DBset.ToListAsync();
        }

        public virtual void UpdateItem(T item)
        {
            DB.Entry(item).State = EntityState.Modified;
        }
    }
}
