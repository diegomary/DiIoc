using Ninject.DeliveryModels;
using Ninject.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.NinjectBindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMessagingService>().To<EmailSender>().Named("Email");
            Bind<IMessagingService>().To<SMSSender>().Named("Sms");
          
        }
    }

}
