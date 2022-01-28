using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Leaderboard.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // Gets the current path (executing assembly)
            string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // Your DB filename    
            string dbFileName = "Demo.db";
            // Creates a full path that contains your DB file
            string absolutePath = Path.Combine(currentPath, dbFileName);

            builder.UseSqlite("Filename=" + absolutePath);
        }
    }
}
