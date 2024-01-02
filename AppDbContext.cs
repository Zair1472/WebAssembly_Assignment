using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAssembly_Assignment.Shared;
namespace WebAssembly_Assignment.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
       
        public DbSet<Donation> Donations { get; set; }

    }
}
