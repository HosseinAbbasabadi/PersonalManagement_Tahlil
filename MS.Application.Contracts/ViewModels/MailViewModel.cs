using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Application.Contracts.ViewModels
{
    public class MailViewModel
    {
        public long Id { get; set; }
        public string Destination { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public MailViewModel(long id, string destination, string subject, string message)
        {
            Id = id;
            Destination = destination;
            Subject = subject;
            Message = message;
        }
    }
}
