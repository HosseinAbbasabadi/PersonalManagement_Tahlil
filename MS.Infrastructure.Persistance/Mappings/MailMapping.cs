using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MS.Domain;

namespace MS.Infrastructure.Persistance.Mappings
{
    public class MailMapping : IEntityTypeConfiguration<Mail>
    {
        public void Configure(EntityTypeBuilder<Mail> builder)
        {
            builder.ToTable("Mails");
            builder.HasKey(x => x.Id);
        }
    }
}