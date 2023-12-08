using BookLibarary.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookLibarary.Data_Context
{
    public class DB_Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DB_Context(DbContextOptions options): base(options) { }

        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent-API
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #endregion

    }
}
