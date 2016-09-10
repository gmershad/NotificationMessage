using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class NotificationCollection : ICollection
    {
        private static int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private Notification[] notificationList;

        public NotificationCollection()
        {
            notificationList = new Notification[MAX_ITEMS];
            addItem("Notification 1");
            addItem("Notification 2");
            addItem("Notification 3");
        }

        public void addItem(String str)
        {
            Notification notification = new Notification(str);

            if (numberOfItems >= MAX_ITEMS)
                Console.WriteLine("Collection is Full");
            else
            {
                notificationList[numberOfItems] = notification;
                numberOfItems = numberOfItems + 1;
            }
        }

        public Iterator CreateIterator()
        {
            return new NotificationIterator(notificationList);
        }
    }
}
