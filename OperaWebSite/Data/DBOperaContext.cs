using Microsoft.EntityFrameworkCore;
using OperaWebSite.Models;

namespace OperaWebSite.Data
{
    public class DBOperaContext : DbContext
    {
        public DBOperaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Opera> Operas { get; set; }
    }
}
