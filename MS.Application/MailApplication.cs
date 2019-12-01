using System;
using System.Collections.Generic;
using System.Linq;
using Framework.Application;
using MS.Application.Contracts;
using MS.Application.Contracts.Commands;
using MS.Application.Contracts.Contracts;
using MS.Application.Contracts.ViewModels;
using MS.Domain;

namespace MS.Application
{
    public class MailApplication : IMailApplication
    {
        private OperationResult _operation;
        private readonly IMailRepository _mailRepository;

        public MailApplication(IMailRepository mailRepository)
        {
            _operation = new OperationResult(Tables.MailTableName);
            _mailRepository = mailRepository;
        }

        public OperationResult Create(CreateMail entity)
        {
            try
            {
                const string source = "hossein@tahlil.com";
                var mail = new Mail(entity.Destination, entity.Subject, entity.Message, source);
                _mailRepository.Create(mail);
                _mailRepository.SaveChanges();
                return _operation.But(Tables.MailTableName).Succeeded(MailMessages.Success);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return _operation.Failed(MailMessages.Failed);
            }
        }

        public List<MailViewModel> GetAll()
        {
            var mails = _mailRepository.GetAll();
            return MapMails(mails);
        }

        private List<MailViewModel> MapMails(IEnumerable<Mail> mails)
        {
            return mails.Select(MapMail).ToList();
        }

        private static MailViewModel MapMail(Mail mail)
        {
            return new MailViewModel(mail.Id, mail.Destination, mail.Subject, mail.Message);
        }
    }
}