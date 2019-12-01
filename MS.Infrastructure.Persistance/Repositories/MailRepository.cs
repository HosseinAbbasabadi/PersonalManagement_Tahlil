using MS.Domain;

namespace MS.Infrastructure.Persistance.Repositories
{
    public class MailRepository : BaseRepository<long, Mail>, IMailRepository
    {
        public MailRepository(MailContext context) : base(context)
        {
        }
    }
}