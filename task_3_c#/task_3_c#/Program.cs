namespace task_3_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            #endregion
            #region 2
            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.Write("Enter an integer: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > 0)
            {
                
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            #endregion
            #region 3
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sec integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("max: " + num1);
                if (num2 <= num3)
                {
                    Console.WriteLine("min: " + num2);
                }
                else
                {
                    Console.WriteLine("min: " + num3);
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("max: " + num2);
                if (num1 <= num3)
                {
                    Console.WriteLine("min: " + num1);
                }
                else
                {
                    Console.WriteLine("min: " + num3);
                }
            }
            else
            {
                Console.WriteLine("max: " + num3);
                if (num1 <= num2)
                {
                    Console.WriteLine("min: " + num1);
                }
                else
                {
                    Console.WriteLine("min: " + num2);
                }
            }
            #endregion
            #region 4
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            #endregion
            #region 5
            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Enter a char: ");
            char char1 = Convert.ToChar(Console.ReadLine());
            char1 = char.ToLower(char1);
            if (char1 == 'a' || char1 == 'e' ||char1 == 'i' || char1 == 'o' || char1 == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion
        }
    }
}
