using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_2.project_1
{
    public class _3D_Point
    {
        #region 1

        //1.	Define 3D Point Class and the basic Constructors (use chaining in constructors).
        public int X { get; set; }

        public int Y { get; set; }
        public int Z { get; set; }

        public _3D_Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public _3D_Point(int x, int y) : this(x, y, 0)
        {
        }

        public _3D_Point(int x) : this(x, 0, 0)
        {
        }

        public _3D_Point() : this(0, 0, 0)
        {
        }

        #endregion 1

        #region 2

        //2.	Override the ToString Function
        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        #endregion 2

        #region 3

        //3.	 Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
        private static int ReadAPoint()
        {
            int point;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out point))
                    break;
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            return point;
        }

        public static _3D_Point Read3DPoint()
        {
            Console.Write("Enter X coordinate:");
            int x = ReadAPoint();
            Console.Write("Enter Y coordinate:");
            int y = ReadAPoint();
            Console.Write("Enter Z coordinate:");
            int z = ReadAPoint();
            return new _3D_Point(x, y, z);
        }

        #endregion 3

        #region 4

        //4.	Try to use == If(P1 == P2)   Does it work properly?
        //no it does not work we should make an overload for the == operator
        public static bool operator ==(_3D_Point p1, _3D_Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(_3D_Point p1, _3D_Point p2)
        {
            return !(p1 == p2);
        }

        #endregion 4

        #region 5

        //5.	Define an array of points and sort this array based on X & Y coordinates.
        public static _3D_Point[] SortPoints(_3D_Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < points.Length; j++)
                {
                    bool swap = false;
                    if (points[j].X < points[minIndex].X)
                    {
                        swap = true;
                    }
                    else if (points[j].X == points[minIndex].X && points[j].Y < points[minIndex].Y)
                    {
                        swap = true;
                    }
                    if (swap)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    _3D_Point temp = points[i];
                    points[i] = points[minIndex];
                    points[minIndex] = temp;
                }
            }
            return points;
        }

        #endregion 5
        #region 6
        //6.	Implement ICloneable interface to be able to clone the object.
        // did we take ICloneable in the course for now?
        #endregion
    }
}