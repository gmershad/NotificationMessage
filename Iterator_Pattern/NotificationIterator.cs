using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class NotificationIterator : Iterator
    {
        private int pos = 0;
        private Notification[] NotificationList;

        public NotificationIterator(Notification[] notificationList)
        {
            NotificationList = notificationList;
        }

        public bool HasNext()
        {
            if (pos >= NotificationList.Length || NotificationList[pos] == null)
                return false;

            return true;
        }

        public object Next()
        {
            Notification notification = NotificationList[pos];
            pos += 1;
            return notification;
        }
    }
}
