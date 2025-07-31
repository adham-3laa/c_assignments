using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q3
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
   
}
