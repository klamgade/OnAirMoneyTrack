using Microsoft.EntityFrameworkCore;
using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.DAL
{
    public class OmackContext: DbContext
    {
        public OmackContext()
        {

        }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=electronpc\\sqlserver;Initial Catalog=Omack-Dev;Integrated Security=True");
        }
    }
}
