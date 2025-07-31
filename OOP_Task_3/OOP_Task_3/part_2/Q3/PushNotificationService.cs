using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q3
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Push notification sent to {recipient}: {message}");
        }
    }
}
