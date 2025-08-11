global using global::System.Collections;

namespace ADV_Task_2

{
    internal static class Program
    {
        #region 1

        //1.	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        private static void reverse_arr_list(ArrayList list)
        {
            if (list == null)
            {
                return;
            }
            int len = list.Count;
            Stack TempList = new Stack(len);
            for (int i = 0; i < len; i++)
            {
                TempList.Push(list[i]);
            }
            for (int i = 0; i < len; i++)
            {
                list[i] = TempList.Pop();
            }
        }

        private static void print_list(ArrayList list)
        {
            foreach (int i in list)
                Console.WriteLine(i);
        }

        #endregion 1

        #region 2

        //2.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
        private static List<int> even_list(List<int> list)
        {
            List<int> EvenList = new List<int>();
            if (list == null)
            {
                return null;
            }
            int len = list.Count;
            for (int i = 0; i < len; i++)
            {
                if (list[i] % 2 == 0)
                    EvenList.Add(list[i]);
                else continue;
            }
            return EvenList;
        }

        private static void print_list(List<int> list)
        {
            foreach (int i in list)
                Console.WriteLine(i);
        }

        #endregion 2
        #region 4
        //4.	Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
        static int CountQuerie(int[] arr, int Querie)
        {
            int count = 0;
            foreach (int i in arr)
                if (i > Querie)
                    count++;
            return count;
        }
        #endregion
        #region 5
        //5.	Given a number N and an array of N numbers. Determine if it's palindrome or not.
        static void alindromeArr(int[] arr)
        {
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++) {
              
                
                if (arr[i] != arr[j])
                {
                    Console.WriteLine("not palindrome");
                    return;
                }
                if (j >= i) break;
                j--;
               
            }
            Console.WriteLine("palindrome");
        }
        #endregion
        #region 6
        //6.	Given an array, implement a function to remove duplicate elements from an array.
        static void removeDuplicate(ref int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
bool duplicate=false;
                for (int j = 0; j < list.Count; j++)
                {
                    if(list[j] == arr[i])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                    list.Add(arr[i]);

            }
            arr = list.ToArray();
        }
        #endregion
        #region 7
        //Given an array list , implement a function to remove all odd numbers from it.
        static void RemoveOdd(ref int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i]%2==0)
                    list.Add(arr[i]);

            }
            arr = list.ToArray();
        }
        #endregion

        private static void Main(string[] args)
        {
            #region 1main

            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            Program.reverse_arr_list(list);
            Program.print_list(list);

            #endregion 1main

            #region 2main

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };

            Program.print_list(Program.even_list(list2));

            #endregion 2main

            #region 3main

            FixedSizeList<int> fixedlist = new FixedSizeList<int>(3);
            fixedlist.Add(1);
            fixedlist.Add(2);
            fixedlist.Add(3);
            fixedlist.Add(4);
            Console.WriteLine(fixedlist.GetValue(0));

            //fixedlist.GetValue(3); will throw Exception

            #endregion 3main
            #region 4main
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(Program.CountQuerie(arr, 2));
            Console.WriteLine(Program.CountQuerie(arr, 5));
            #endregion
            #region 5MAIN
            int[] arr2 = new int[] { 1, 2, 3 ,3, 2, 1 };
            Program.alindromeArr(arr2);
            arr2= new int[] { 1, 2, 2, 3, 2, 1 };
            Program.alindromeArr(arr2);
            #endregion
            #region 6MAIN
            Program.removeDuplicate( ref arr2);
            foreach(int i in arr2)
                Console.WriteLine(i);

            #endregion
            #region 7main
            Console.WriteLine("----------------------------s");
            arr2 = new int[] { 1, 2, 2, 3, 2, 1 };
            Program.RemoveOdd(ref arr2);
            foreach (int i in arr2)
                Console.WriteLine(i);
            #endregion

        }
    }
}