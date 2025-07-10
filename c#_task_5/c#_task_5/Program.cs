using System.ComponentModel;

namespace c__task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            Console.Write("Enter the size:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            #endregion
            #region 2
            // 20- Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (var item in arr)
                sum += item;
            Console.WriteLine("the sum of the array:" + sum);

            #endregion
            #region 3
            //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            Console.WriteLine();
            int[] arr1 = { 1, 5, 3, 9 };
            int[] arr2 = { 2, 4, 7, 6 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, arr3, arr1.Length);
            Array.Copy(arr2, 0, arr3, arr1.Length, arr2.Length);
            Console.WriteLine("the merged array:");
            foreach (var item in arr3)
                Console.Write(item + " ");
            Array.Sort(arr3);
            Console.WriteLine();
            Console.WriteLine(" the sorted array:");
            foreach (var item in arr3)
                Console.Write(item + " ");
            #endregion
            Console.WriteLine();
            #region 4
            //22- Write a program in C# Sharp to count the frequency of each element of an array.
            char[] ar = {'a', 'b', 'c', 'a', 'b', 'a' ,'d'};
            bool[] visited = new bool[ar.Length];
            for (int i = 0;i < ar.Length; i++)
            {
                if (visited[i]) //skip visted characters
                    continue;
                int count = 0;
                for (int j =0; j < ar.Length; j++)
                {
                  
                    if (ar[i] == ar[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }
                Console.WriteLine($"Element {ar[i]} occurs {count} times.");
            }
            #endregion
            Console.WriteLine();
            #region 5
            //23- Write a program in C# Sharp to find maximum and minimum element in an array
            int[] arr4 = { 554, 5, 23, 468, 346, 99, 765 };
            int max = arr4[0];
            int min = arr4[0];
            foreach (var item in arr4)
            {
                if (item > max)
                    max = item;
                if (item < min)
                    min = item;
            }
            Console.WriteLine($"maximum element: {max}");
            Console.WriteLine($"minimum element: {min}");
            #endregion
            #region 6
            //24- Write a program in C# Sharp to find the second largest element in an array.
            int[] arr5 = { 554, 5, 23, 468, 346, 99, 765 };
            int maxv=arr5.Max();
            int theSecLargest = 0;
            foreach (var item in arr5)
            {
                if (item > theSecLargest && item < maxv)
                    theSecLargest = item;
            }
            Console.WriteLine($"the second largest element: {theSecLargest}");
            #endregion
            #region 7
            //25-. Consider an Array of Integer values with size N, having values as in this Example
            Console.WriteLine("enter the size of arr");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr6 = new int[size];
            Console.WriteLine("enter the values of arr");
            for (int i = 0; i < size; i++)
                arr6[i] = Convert.ToInt32(Console.ReadLine());
            int maxDis = 0;
            for(int i = 0;i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr6[i] == arr6[j])
                    {
                        int dis = j - i - 1;
                        if (dis > maxDis)
                        {
                            maxDis = dis;
                        }
                    }
                }
            }
            Console.WriteLine($"the maximum distance is: {maxDis}");
            #endregion
            #region 8
            // 26- Given a list of space separated words, reverse the order of the words.
            Console.WriteLine("enter the words");
            string s1 = Console.ReadLine();
            string[] sArr = s1.Split();
            Array.Reverse(sArr);
            Console.WriteLine(string.Join(" ", sArr));
            #endregion
            #region 9
            //27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            Console.WriteLine("enter the num of rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num of columns");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr7 = new int[r, c];
            int[,] arr8 = new int[r, c];
            Console.WriteLine("enter the values of the array");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr7[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr8[i, j] = arr7[i, j];
                }
            }
            Console.WriteLine("the second array is:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write(arr8[i, j] + " ");
                Console.WriteLine();
            }
            #endregion
            #region 10
            //28- Write a Program to Print One Dimensional Array in Reverse Order
            int[] arr9 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("the array in reverse order:");
            for (int i = arr9.Length - 1; i >= 0; i--)
            {
                Console.Write(arr9[i] + " ");
            }
            #endregion
        }
    }
}
