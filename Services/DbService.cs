using Cricketers_FinalProject_BackendAPI.Context;
using Microsoft.EntityFrameworkCore;
using Cricketers_FinalProject_BackendAPI.Context;
using Cricketers_FinalProject_BackendAPI.Models;


namespace Cricketers_FinalProject_BackendAPI.Services
{
    public class DbService : IDbService
    {
        CricDbContext db;

        public DbService(CricDbContext db)
        {
            this.db = db;
        }


        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> Get<T>(int id) where T : class
        {
            return await db.Set<T>().FindAsync(id);

        }
        public async Task Add<T>(T c)
        {
            await db.AddAsync(c);
            await db.SaveChangesAsync();
        }

        public async Task Delete<T>(int id) where T : class
        {
            var CricDel = db.Cricketers.Find(id);
            if (CricDel is not null)
            {
                db.Remove(CricDel);
                await db.SaveChangesAsync();
            }


        }

        public async Task Update<T>(int id, T data) where T : class
        {
            var CricUpdate = db.Cricketers.Find(id);

            if (CricUpdate is not null)
            {
                db.Entry(CricUpdate).State = EntityState.Detached;
                db.Entry(data).State = EntityState.Modified;

                await db.SaveChangesAsync();
            }

        }
    }
}