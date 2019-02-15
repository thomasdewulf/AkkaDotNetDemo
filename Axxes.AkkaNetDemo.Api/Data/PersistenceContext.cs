using Microsoft.EntityFrameworkCore;

namespace Axxes.AkkaNetDemo.Api.Data
{
    public class PersistenceContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=persistence.db");
        }
    }
}