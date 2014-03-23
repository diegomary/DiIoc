using Ninject.DeliveryModels;
using Ninject.Interfaces;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
           
            //First Case we want to resolve Email Sender
            var p1 = new ConstructorArgument("emailaddress", "diego@dmm888.com");
            var p2 = new ConstructorArgument("emailsubject", "this is the subject");
            var p3 = new ConstructorArgument("messagebody", "This is the body of the email");            
            var processor = kernel.Get<IMessagingService>("Email",p1,p2,p3);
            NotificationSystem ns = new NotificationSystem(processor);
            ns.Notify();
            Console.WriteLine();
          
            //Second Case we want to resolve Email Sender
            var p11 = new ConstructorArgument("telephoneNumber", "07771456918");
            var p22 = new ConstructorArgument("smsbody", "The Body of the SMS message is this");        
            var processor1 = kernel.Get<IMessagingService>("Sms", p11, p22);
            NotificationSystem ns1 = new NotificationSystem(processor1);
            ns1.Notify();
            Console.ReadLine();

        }
    }
}
