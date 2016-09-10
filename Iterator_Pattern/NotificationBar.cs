using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class NotificationBar
    {
        private NotificationCollection Notifications;

        public NotificationBar(NotificationCollection notification)
        {
            Notifications = notification;
        }

        public void printNotifications()
        {
            Iterator iterator = Notifications.CreateIterator();
            Console.WriteLine("*****TIFICATION MESSAGE****");

            while (iterator.HasNext())
            {
                Notification n = (Notification)iterator.Next();
                Console.WriteLine(n.Notifications);
            }
        }
    }
}
