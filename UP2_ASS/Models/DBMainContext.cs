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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;
                                        Database=BookShopSA;
                                        Trusted_Connection=True;
                                        TrustServerCertificate=True;");
        }

        public DBMainContext()
        {
            Database.EnsureCreated();
        }
    }
}
