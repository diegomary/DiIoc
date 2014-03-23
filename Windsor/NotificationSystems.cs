using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windsor.Interfaces;

namespace Windsor
{
    public class NotificationSystem
    {
        public IMessagingService SVC { get; set; }
        public NotificationSystem() { } // parametreless constructor in this case property must be filled
        public NotificationSystem(IMessagingService service)
        {
            this.SVC = service;
        }
        public void Notify()
        {
            if (SVC == null) // check if the object is not null
            {
                throw new InvalidOperationException("Please set MessagingService before calling " + "Notify().");
            }

            SVC.SendMessage();
        }
    }
}
