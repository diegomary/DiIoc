using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windsor.DeliveryModels;
using Windsor.Interfaces;

namespace Windsor.Installers
{
    
public class Installers : IWindsorInstaller 
  { 
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store) 
        {
            container.Register(Component.For<IMessagingService>().ImplementedBy<EmailSender>().LifestyleTransient().Named("Email"));
            container.Register(Component.For<IMessagingService>().ImplementedBy<SMSSender>().LifestyleTransient().Named("Sms"));

        } 

    } 

}
