using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c__task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Enter a num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num1; i++)
            {
                Console.Write($"{i} ");
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine("------------------------------"); 
            #region 2
            // 7 - Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.
            Console.Write("Enter a num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num2 * i);
            }
            #endregion
            Console.WriteLine("------------------------------");
            #region 3
            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.Write("Enter a num:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num3; i+=2)
             Console.Write($"{i} ");
            
            #endregion
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            #region 4
            //9- Write a program that takes two integers then prints the power.
            Console.Write("Enter a num:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the power:");
            int power = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            for (int i = 1; i <= power; i ++) { 
                x*=num4;
            }
            Console.WriteLine(x);
            #endregion
            #region 5
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.Write("Enter marks of five subjects : ");
            double total = 0;
            for (int i = 1; i <= 5; i++)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                total += mark;
            }
            Console.WriteLine($"Total marks:{total}");
            Console.WriteLine($"Average marks:{total / 5}");
            Console.WriteLine($"Percentage:{(total / 500) * 100}%");
            #endregion
            Console.WriteLine("------------------------------");
            #region 6
            //11- Write a program to input the month number and print the number of days in that month.
            Console.Write("Enter month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            if (month==1 || month== 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("31 days");
            }
            else if (month == 2)
            {
                Console.WriteLine("28 days or 29 in leap years");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 days");
            }
            else
            {
                Console.WriteLine("Invalid month number");
            }
            #endregion
            Console.WriteLine("------------------------------");
            #region 7
            //11- Write a program to input the month number and print the number of days in that month.
            char y;
            do
            {
                Console.Write("Enter first number");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number");
                int secondNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the operator: ");
                char operator1 = Convert.ToChar(Console.ReadLine());
                switch (operator1)
                {
                    case '+':
                        Console.WriteLine($"Result: {firstNum + secondNum}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {firstNum - secondNum}");
                        break;
                    case '*':
                        Console.WriteLine($"Result: {firstNum * secondNum}");
                        break;
                    case '/':
                        Console.WriteLine($"Result: {firstNum / secondNum}");
                        break;
                    case '%':
                        Console.WriteLine($"Result: {firstNum % secondNum}");
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
                Console.Write("Do you want to continue? (y/n): ");
                 y = Convert.ToChar(Console.ReadLine());
            } while (char.ToLower(y) == 'y');

            #endregion
            Console.WriteLine("------------------------------");
            #region 8
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            #region 9
            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            Console.Write("Enter an integer: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            string numStr = num6.ToString();
            if (num6 < 0) numStr = numStr.Substring(1); // Remove the negative sign for reversal

            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                Console.Write(numStr[i]);
            }

            #endregion
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            #region 10
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            for (int num = start; num <= end; num++)
            {
                if (num < 2) continue;
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write($"{num} ");
                }
            }

            #endregion
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            #region 11
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("Enter the x and y of the first point:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x and y of the second point:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x and y of the third point:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            double m1 = (double)(y2 - y1) / (x2 - x1);
            double m2 = (double)(y3 - y2) / (x3 - x2);
            if (m1 == m2) Console.WriteLine("The points lie on a single straight line.");
            else Console.WriteLine("The points do not lie on a single straight line.");
            #endregion
            Console.WriteLine("------------------------------");
            #region 12
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
- If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
- If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
- If the worker takes more than 5 hours, they are required to leave the company. 
To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
*/
            Console.Write("Enter the hours: ");
            float hours = Convert.ToSingle(Console.ReadLine());
            if (hours>=2 && hours<=3)
                Console.WriteLine("Highly efficient");
            else if (hours > 3 && hours <= 4)
                Console.WriteLine("Increase your speed");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("Training to enhance your speed");
            else if (hours > 5)
                Console.WriteLine("required to leave the company");
            else
                Console.WriteLine("Invalid input");
            #endregion
        }
    }
}
