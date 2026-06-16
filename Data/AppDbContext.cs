using Emptyp.Models;
using Microsoft.EntityFrameworkCore;


namespace Emptyp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}