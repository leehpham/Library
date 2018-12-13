using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    // 1st we need to create this class and it needs to inherit from DbContext
    // System.Data.Entity.DbContext: Interacts with and manages entity objects for our application, including filling objects with data
    // from a data source, change tracking, and saving data back to the database.
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        // DbSet<TEntity> represents an entity used for CRUD operations - intuitively, think of DbContext as representing your database,
        // and DbSet<SomeEntity> as representing a table in that database.
        public DbSet<Patron> Patrons { get; set; }
    }
}
