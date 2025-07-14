namespace task_6_C_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1

            //1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*passing by value is take the value of the parameters as a copy in the stack and don't make any change in the main variable
            but passing by reference is to take copy of the reference and store it in the stack so any change will be stored in the main variable
             */
            void swap_v(int x, int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            void swap_r(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            int x1 = 17, y1 = 2;
            Console.WriteLine($"Before: x1 = {x1}, y1 = {y1}");
            swap_v(x1, y1);
            Console.WriteLine($"After swap by value: x1 = {x1}, y1 = {y1}"); // x1 = 20, y1 = 10
            swap_r(ref x1, ref y1);
            Console.WriteLine($"After swap by refrence: x1 = {x1}, y1 = {y1}"); // x1 = 20, y1 = 10

            #endregion 1

            #region 2

            //2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /* passing by value for reference type parameters means that the reference to the object is copied but the object is not copied.
            passing by reference means that we take the reference of the place that hold the referene of the parameter and allowing changes to the object to be reflected.*/
            void array_v(int[] v)
            {
                v[0] = 100;//Change first Element
                v = new int[] { 1, 2, 3, 4, 5 };
            }
            void array_r(ref int[] v)
            {
                v[0] = 100;//Change first Element
                v = new int[] { 1, 2, 3, 4, 5 };
            }

            int[] arr1 = new int[] { 54, 65, 34, 50, 75 };
            Console.WriteLine("before change");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after passing by value");
            array_v(arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item); // will not change the array
            }
            Console.WriteLine("after passing by reference");
            array_r(ref arr1);
            foreach (var item in arr1)
            {
                Console.WriteLine(item); // will change the array
            }

            #endregion 2

            #region 3

            //3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            void sum_and_subtract(int x, int y, int z, int a, out int sum, out int sub)
            {
                sum = x + y;
                sub = z - a;
            }
            int x = 20, y = 43, z = 100, a = 45;
            int sum, sub;
            sum_and_subtract(x, y, z, a, out sum, out sub);
            Console.WriteLine($"Sum of {x} and {y} = {sum}");
            Console.WriteLine($"Sub of {z} and {a} = {sub}");

            #endregion 3

            #region 4

            //4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be likeEnter a number: 25The sum of the digits of the number 25 is: 7
            void sum_of_digits(int x)
            {
                int S = 0;
                string y;
                y = x.ToString();
                for (int i = 0; i < y.Length; i++)
                {
                    S += Convert.ToInt32(y[i].ToString());
                }
                Console.WriteLine($"the sum of the digits is :{S}");
            }
            Console.WriteLine("enter the num");
            int n = Convert.ToInt32(Console.ReadLine());
            sum_of_digits(n);

            #endregion 4

            #region 5

            //5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            bool IsPrime(int x)
            {
                bool isPrime = true;
                if (x < 2) return false;

                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                return isPrime;
            }
            Console.WriteLine("enter the num");
            int p = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(p))
                Console.WriteLine("is prime");
            else Console.WriteLine("not prime");

            #endregion 5

            #region 6

            // 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            void MinMaxArray(int[] arr, out int min, out int max)
            {
                min = arr[0];
                max = arr[0];
                foreach (var item in arr)
                {
                    if (item < min) min = item;
                    if (item > max) max = item;
                }
            }
            int[] arr2 = new int[] { 54, 65, 34, 50, 75 };
            int min, max;
            MinMaxArray(arr2, out min, out max);
            Console.WriteLine($"Min = {min}, Max = {max}");

            #endregion 6

            #region 7

            //7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            int fact(int n)
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            Console.WriteLine("enter the num");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"factorial of {f} is {fact(f)}");

            #endregion 7

            #region 8

            //8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            string ChangeChar(string str, int position, char newchar)
            {
                if (position < 0 || position >= str.Length)
                {
                   return "Position out of range";
                 
                }
                char[] c = str.ToCharArray();
                c[position] = newchar;
                string modifiedS = new string(c);
                return modifiedS;
            }
            string str = "adhan";
            int position = 4;
            char newchar = 'm';
            ChangeChar(str, position, newchar);
            Console.WriteLine($"Modified String: {ChangeChar(str, position, newchar)}");

            #endregion 8
        }
    }
}