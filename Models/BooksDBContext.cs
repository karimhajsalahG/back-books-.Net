using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiBooksCrud.Models
{
    public partial class BooksDBContext : DbContext
    {
    

        public BooksDBContext(DbContextOptions<BooksDBContext> options)
            : base(options)
        {
        }

       

        public virtual DbSet<Book> Books { get; set; }
    }
}
