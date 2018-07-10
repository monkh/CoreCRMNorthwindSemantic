using CoreCRMNorthwindSemantic_DataLayer.Models.CoreCRMUI;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreCRMNorthwindSemantic_DataLayer
{
    public class NorthwindDataContext : DbContext
    {
        //public DbSet<> Blog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
    }

    public class NorthwindUIContext : DbContext
    {
        public DbSet<TabQuery> TabQuery { get; set; }
        public DbSet<TabSettings> TabSettings { get; set; }
        public DbSet<UserTabStateModel> UserTabStateModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EDEN\SQLEXPRESS01;Database=NORTHWIND;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
