using Microsoft.AspNetCore.Mvc;
using Cricketers_FinalProject_BackendAPI.Services;
using Cricketers_FinalProject_BackendAPI.Models;
using Cricketers_FinalProject_BackendAPI.Services;
using static Cricketers_FinalProject_BackendAPI.Models.Cricketer;
using Cricketers_FinalProject_BackendAPI.Models;

namespace Cricketers_FinalProject_BackendAPI.Endpoints
{
    public static class CricketerAPI
    {
        static string endpoint = "/api/cricketers";
        public static void MapCricketerEndpoints(this WebApplication app)
        {
            app.MapGet(endpoint + "/All", async (IDbService dbs) => await dbs.GetAll<Cricketer>());
            app.MapGet(endpoint + "/{id}",
                async (IDbService dbs, int id) =>
                await dbs.Get<Cricketer>(id));
            app.MapPost(endpoint + "/Add",
                async (IDbService dbs, Cricketer c) =>
                await dbs.Add(c));
            app.MapDelete(endpoint + "/Delete/{id}",
               static async (IDbService dbs, int id) =>
                await dbs.Delete<Cricketer>(id));
            app.MapPut(endpoint + "/Update/{id}",
                async (IDbService dbs, int id, Cricketer data) =>
                await dbs.Update(id, data));
            
        }
    }
}

