using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_task_1
/*1.	The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
And implement the code of this optimized bubble sort algorithm
---------------------------------------------------------------------------------
*we make a flag to check if any swap has been done in the second loop if not it means the array is sorted and we can break the loop early.
*/
{
    internal class BubbleSort
    {
        public static void Sort(int[] array)
        {
            
            bool swapped;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped==false)
                    break;
            }
        }
    }
}
