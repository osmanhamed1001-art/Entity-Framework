using EF001.Modesl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF001
{
    public class BookstoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF001;Trusted_connction=true;TrustServerCretificate=True");

        }

       public DbSet<Book>Books { get; set; }
       public DbSet<Author> Authors { get; set; }
       public DbSet<Category> Categorys { get; set; }




    }
}
