﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationCollection notificationCollection = new NotificationCollection();
            NotificationBar notificationBar = new NotificationBar(notificationCollection);
            notificationBar.printNotifications();
            Console.ReadKey();
        }
    }
}
