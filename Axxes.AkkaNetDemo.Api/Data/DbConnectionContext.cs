using Axxes.AkkaNetDemo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Axxes.AkkaNetDemo.Api.Data
{
    public class DbConnectionContext: DbContext

    
    {
        
        public DbSet<HourlyConsumption> HourlyConsumptions { get; set; }
        
        public DbSet<HighConsumptionAlerts> HighConsumptionAlerts { get; set; }
        
        public DbConnectionContext(DbContextOptions<DbConnectionContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dbConnection.db");
        }
    }
}