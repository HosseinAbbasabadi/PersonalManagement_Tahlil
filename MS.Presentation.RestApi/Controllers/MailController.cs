using System.Collections.Generic;
using Framework.Application;
using Microsoft.AspNetCore.Mvc;
using MS.Application.Contracts.Commands;
using MS.Application.Contracts.Contracts;
using MS.Application.Contracts.ViewModels;

namespace MS.Presentation.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailApplication _mailApplication;

        public MailController(IMailApplication mailApplication)
        {
            _mailApplication = mailApplication;
        }

        [HttpPost]
        public OperationResult Post(CreateMail command)
        {
            return _mailApplication.Create(command);
        }

        [HttpGet]
        public List<MailViewModel> GetAll()
        {
            return _mailApplication.GetAll();
        }
    }
}