using DemoApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace DemoApp.Data
{
    public class SamuraiContext: DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        private readonly string _connectionString = "Data Source=LAPTOP-R0IBRK5V\\MSSQLSERVER01;Initial Catalog=SamuraiDemo;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            // base.OnConfiguring(optionsBuilder);
        }
    }
}
