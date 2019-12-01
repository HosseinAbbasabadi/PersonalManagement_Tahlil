using Microsoft.EntityFrameworkCore;
using MS.Domain;
using MS.Infrastructure.Persistance.Mappings;

namespace MS.Infrastructure.Persistance
{
    public class MailContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }

        public MailContext(DbContextOptions<MailContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(MailMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            modelBuilder.ApplyConfiguration(new MailMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }
    }
}