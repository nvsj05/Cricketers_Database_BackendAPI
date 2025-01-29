using Cricketers_FinalProject_BackendAPI.Models;

namespace Cricketers_FinalProject_BackendAPI.Services
{
    public interface IDbService
    {
        Task<List<T>> GetAll<T>() where T : class;
        Task<T> Get<T>(int id) where T : class;
        Task Add<T>(T s);

        Task Delete<T>(int id) where T : class;
        Task Update<T>(int id, T data) where T : class;

    }
}
