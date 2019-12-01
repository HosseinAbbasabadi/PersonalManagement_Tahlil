using System.ComponentModel.DataAnnotations;
using Framework.Application;

namespace MS.Application.Contracts.Commands
{
    public class CreateMail : ICommand
    {
        public string Destination { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}