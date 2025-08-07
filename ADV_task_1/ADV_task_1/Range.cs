using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ADV_task_1
{/*2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
  */

    #region 1

    //1.	Create a generic class named Range<T> where T represents the type of values.
    internal class Range<T> where T : IComparable<T>, ISubtractionOperators<T,T,T> //i used ISubtractionOperators because not all types spport the Subtraction

        #endregion 1

    {
        public T Min { get; set; }
        public T Max { get; set; }

        #region 2
       //2	Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }
        #endregion 2
        #region 3
        //3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        public bool IsInRange(T value) { 
            return value.CompareTo(Min)>=0 && value.CompareTo(Max)<=0;        
        }
        #endregion
        #region 3
        //4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        public T length()
        {
            return Max - Min;

        }
        #endregion
         
    }
}