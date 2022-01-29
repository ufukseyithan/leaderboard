using Leaderboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Leaderboard.Data
{
    public class EntryContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            if (baseDir.Contains("bin"))
            {
                int index = baseDir.IndexOf("bin");
                baseDir = baseDir.Substring(0, index);
            }

            options.UseSqlite($"Data Source={baseDir}Databases\\Demo.db");
        }
    }
}
