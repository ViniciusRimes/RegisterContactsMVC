
using Microsoft.EntityFrameworkCore;
using RegisterContactsMVC.Models;

namespace RegisterContactsMVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<ContactModel> Contacts { get; set; }
    }
}