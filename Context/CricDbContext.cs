using System.Collections.Generic;
using  Cricketers_FinalProject_BackendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Cricketers_FinalProject_BackendAPI.Context
{
    public class CricDbContext : DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }

        public CricDbContext(DbContextOptions<CricDbContext> options) : base(options)
        {

        }

    }
}
