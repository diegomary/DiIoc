using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Interfaces;

namespace IOC.DeliveryModels
{
    public class EmailSender : IMessagingService
    {
        public string Emailaddress { get; set; }
        public string EmailSubject { get; set; }
        public string MessageBody { get; set; }
        public EmailSender(string emailaddress, string emailsubject, string messagebody)
        {
            Emailaddress = emailaddress;
            EmailSubject = emailsubject;
            MessageBody = messagebody;
        }
        public void SendMessage()
        {
            Console.WriteLine("Sent mail to: {0}  with subject: {1} and Message: {2} ", this.Emailaddress, this.EmailSubject, this.MessageBody);
        }
    }
}
