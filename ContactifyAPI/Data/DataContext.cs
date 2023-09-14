using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ContactifyAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
