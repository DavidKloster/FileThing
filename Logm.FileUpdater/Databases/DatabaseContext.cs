using System;
using Logm.FileUpdater.Sdk.Models;
using Microsoft.EntityFrameworkCore;


namespace Logm.FileUpdater.Databases
{
    public class DatabaseContext : DbContext
    {
        public string DbPath { get; }

        public DbSet<VersionFile>? VersionFiles { get; set; }

        public DatabaseContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "nicelocaldb.db");

            this.Database.EnsureCreate‚d();
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<VersionFile>().HasKey(x => x.ID);
        }

    }
}
