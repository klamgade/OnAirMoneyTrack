using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.DAL
{
    public class OmackContext: DbContext
    {
        //IConfiguration _config;
        public OmackContext()
        {
        }
        public DbSet<Group> Groups { get; set; } 
        public DbSet<Group_User> Group_User { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=DESKTOP-SDQNFF2\\SQLSERVER;Initial Catalog=Omack-Dev;Integrated Security=True");

            //TODO: Use config file for connection string..
            //TODO: Add Indentity User - using identity framework
        }
    }
}
