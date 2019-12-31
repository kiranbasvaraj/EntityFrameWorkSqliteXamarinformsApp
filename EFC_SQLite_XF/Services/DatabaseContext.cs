using EFC_SQLite_XF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EFC_SQLite_XF.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ProductsModel> Products { get; set; }



        public DatabaseContext()
        {


            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(string.Format("Filename={0}", DependencyService.Get<ISqlConnection>().GetSqlPath()));
        }
    }
}
