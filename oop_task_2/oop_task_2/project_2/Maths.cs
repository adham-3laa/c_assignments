using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_2.project_2
{
    public class Maths
    {
        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double subtract(double a, double b)
        {
            return a - b;
        }
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static double divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero. Returning 0 instead.");
                return 0; 
            }
            return a / b;
        }
    }
}
