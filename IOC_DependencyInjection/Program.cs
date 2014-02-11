using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC.Interfaces;
using IOC.DeliveryModels;

namespace IOC_DependencyInjection
{
    class Program
    { 

        static void Main(string[] args)
        {
            // First case: Constructor Injection
            IMessagingService imsg = new EmailSender("myname.google.com", "Mark is saying:", "Hello how are you");
            NotificationSystem ns = new NotificationSystem(imsg);
            ns.Notify();
            // Second Case: property injection.
            ns = new NotificationSystem();
            imsg = new SMSSender("004479234567", "This is an SMS sent from me");
            ns.SVC = imsg;
            Console.WriteLine();
            ns.Notify();
            Console.ReadLine();
        }
    }
}
