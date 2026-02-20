using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP2_ASS.Models
{
    internal class DBMainContext: DbContext 
    {
        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=localdb.db");
        }

        public DBMainContext()
        {
            Database.EnsureCreated();
        }
    }
}
