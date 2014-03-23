using Ninject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.DeliveryModels
{
    public class SMSSender : IMessagingService
    {
        public string TelephoneNumber { get; set; }
        public string SmsBody { get; set; }

        public SMSSender(string telephoneNumber, string smsbody)
        {
            TelephoneNumber = telephoneNumber;
            SmsBody = smsbody;
        }
        public void SendMessage()
        {
            Console.WriteLine("Sent SMS to: {0}  TEXT: {1} ", this.TelephoneNumber, this.SmsBody);
        }
    }
}
