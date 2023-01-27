using ClinicaWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaWebSite.Data
{
    public class DBClinicaMVCContext : DbContext
    {
        public DBClinicaMVCContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Medico> Medicos { get; set; }
    }
}
