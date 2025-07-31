using System.Drawing;
using OOP_Task_3.part_2.Q1;
using OOP_Task_3.part_2.Q2;
using OOP_Task_3.part_2.Q3;

namespace OOP_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            Circle circle = new Circle(8);
            circle.DisplayShapeInfo();
            Rectangle1 rectangle = new Rectangle1(3, 7);
            rectangle.DisplayShapeInfo();
            #endregion
            #region Q2
            BasicAuthenticationService basicAuthService = new BasicAuthenticationService();
            if (basicAuthService.AuthenticateUser("admin", "admin"))
            {
                Console.WriteLine("User is authenticated.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
            if (basicAuthService.AuthenticateUser("adham", "admin"))
            {
                Console.WriteLine("User is authenticated.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
            if(basicAuthService.AuthorizeUser("admin", "Admin"))
            {
                Console.WriteLine("User is authorized.");
            }
            else
            {
                Console.WriteLine("Authorization failed.");
            }
            if (basicAuthService.AuthorizeUser("admin", "employee"))
            {
                Console.WriteLine("User is authorized.");
            }
            else
            {
                Console.WriteLine("Authorization failed.");
            }
            #endregion
            #region Q3
            INotificationService notificationService = new EmailNotificationService();
            notificationService.SendNotification("hello", "adham");
            notificationService = new SmsNotificationService();
            notificationService.SendNotification("hello", "adham");
            notificationService = new PushNotificationService();
            notificationService.SendNotification("hello", "adham");
            #endregion






        }
    }
}
