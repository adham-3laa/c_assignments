using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_2.project_3
{
    public class Duration
    {
        #region 1
        //1.	Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int totalSeconds
        {
            get
            {
                return Hours * 3600 + Minutes * 60 + Seconds;
            }
        }


        #endregion
        #region 2
        //2.	Override All System.Object Members (ToString, Equals,GetHasCode) .
        public override string ToString()
        {
            if (Minutes == 0 && Hours==0) return $"Seconds :{Seconds}";
           else if (Hours == 0) return $"Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";

        }

        public override bool Equals(object obj)
        {
            if (obj is Duration d)
            {
                return this.totalSeconds == d.totalSeconds;
            }
            return false;
        }
        public override int GetHashCode()
        { return totalSeconds.GetHashCode(); }

        #endregion
        #region 3
        //3.	Define All Required Constructors to Produce this output:Duration D1 = new Duration(1, 10, 15);D1.ToString(); Output: Hours: 1, Minutes :10, Seconds :15Duration D1 = new Duration(3600);D1.ToString(); Output: Hours: 1, Minutes :0, Seconds :0Duration D2 = new Duration(7800);D2.ToString(); Output: Hours: 2, Minutes :10, Seconds :0Duration D3 = new Duration(666);D3.ToString(); Output: Minutes :11, Seconds :6
        public Duration(int hours, int minutes, int seconds)
        {
            do
            {
                Hours = hours;
                if (seconds >= 60)
                {
                    Minutes += seconds / 60;
                    Seconds = seconds % 60;
                }
                else
                    Seconds = seconds;
                    if (minutes >= 60)
                {
                    Hours += minutes / 60;
                    Minutes = minutes % 60;
                }
                else
                {
                    Minutes = minutes;
                }
               
                
            } while (minutes >= 60 || seconds >= 60);
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }


        #endregion
        #region 4
        //4.	Implement All required Operators overloading to enable this Code●	D3=D1+D●	D3=D1 + 780●	D3=666+D●	D3= ++D1(Increase One Minute●	D3 = --D2(Decrease One Minute●	D1= D1 -D●	If(D1>D2●	If(D1<=D2●	If(D1)●	DateTime Obj = (DateTime)D1
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d1)
        {
            return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }
        public static Duration operator ++(Duration d1)
        {
            return new Duration(d1.Hours, d1.Minutes + 1, d1.Seconds);
        }
        public static Duration operator --(Duration d1)
        {
            int total = d1.totalSeconds - 60;
            return new Duration(total);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.totalSeconds - d2.totalSeconds;
            return new Duration(totalSeconds);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.totalSeconds > d2.totalSeconds;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.totalSeconds <= d2.totalSeconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.totalSeconds < d2.totalSeconds;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.totalSeconds >= d2.totalSeconds;

        }
        public static bool operator true(Duration d)
        {
            return d.totalSeconds > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.totalSeconds <= 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        #endregion


    }
}
