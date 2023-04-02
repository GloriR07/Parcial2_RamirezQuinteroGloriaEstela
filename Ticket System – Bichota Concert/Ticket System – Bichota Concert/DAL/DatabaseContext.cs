using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Ticket_System___Bichota_Concert.DAL.Entities;

namespace Ticket_System___Bichota_Concert.DAL
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }//mapeo de mi entidad para poder ser leida
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.CodTicket).IsUnique();
        }
    }
}
