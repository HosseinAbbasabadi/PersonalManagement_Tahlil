using System;

namespace MS.Domain
{
    public class Mail
    {
        public long Id { get; set; }
        public string Destination { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public string Source { get; set; }

        public Mail(string destination, string subject, string message, string source)
        {
            Validate(destination, subject);

            Destination = destination;
            Subject = subject;
            Message = message;
            Source = source;
            CreationDate = DateTime.Now;
        }

        private static void Validate(string destination, string subject)
        {
            GuardAgainstNullDestination(destination);
            GuardAgainstNullSubject(subject);
        }

        private static void GuardAgainstNullDestination(string destination)
        {
            if (string.IsNullOrEmpty(destination))
                throw new NullReferenceException();
        }

        private static void GuardAgainstNullSubject(string subject)
        {
            if (string.IsNullOrEmpty(subject))
                throw new NullReferenceException();
        }
    }
}