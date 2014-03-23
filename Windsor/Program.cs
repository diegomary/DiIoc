using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windsor.DeliveryModels;
using Windsor.Interfaces;

namespace Windsor
{
    class Program
    {
        static void Main(string[] args)
        {
          
           var container = new WindsorContainer();
           container.Install(FromAssembly.This());
           var resolveToemailsender = container.Resolve<IMessagingService>("Email", new {emailaddress= "pluto@palla.com", emailsubject ="ziopippo", messagebody = "This is a test"});
           var resolveTosmssender = container.Resolve<IMessagingService>("Sms", new { telephoneNumber = "pluto@palla.com", smsbody = "ziopippo" });
           NotificationSystem notifyEmail = new NotificationSystem(resolveToemailsender);
           notifyEmail.Notify();
           Console.WriteLine();
           NotificationSystem notifySms = new NotificationSystem(resolveTosmssender);
           notifySms.Notify();
           Console.ReadLine();

        }
    }
}
