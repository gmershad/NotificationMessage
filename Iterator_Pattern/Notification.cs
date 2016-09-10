using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class Notification
    {

        public string Notifications { get; set; }

        public Notification(string notification)
        {
            Notifications = notification;
        }
    }
}
