using System.Collections.Generic;
using Framework.Application;
using MS.Application.Contracts.Commands;
using MS.Application.Contracts.ViewModels;

namespace MS.Application.Contracts.Contracts
{
    public interface IMailApplication
    {
        OperationResult Create(CreateMail command);
        List<MailViewModel> GetAll();
        MailViewModel Get(long id);
    }
}
