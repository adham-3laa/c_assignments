using oop_task_2.project_1;
using oop_task_2.project_3;

namespace oop_task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region project 1

            //#region 1.2_test

            //_3D_Point P = new _3D_Point(10, 10, 10);
            //Console.WriteLine(P.ToString());

            //#endregion 1.2_test

            //#region 1.3_test

            //Console.WriteLine("Enter coordinates for Point 1:");
            //_3D_Point P1 = _3D_Point.Read3DPoint();
            //Console.WriteLine("Enter coordinates for Point 2:");
            //_3D_Point P2 = _3D_Point.Read3DPoint();
            //Console.WriteLine($"Point 1: {P1}");
            //Console.WriteLine($"Point 2: {P2}");

            //#endregion 1.3_test

            //#region 1.4_test

            //if (P1 == P2)
            //{
            //    Console.WriteLine("The two points are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("The two points are not equal.");
            //}

            //#endregion 1.4_test

            //#region 1.5_test

            //_3D_Point[] points = new _3D_Point[5];
            //points[0] = new _3D_Point(1, 2, 3);
            //points[1] = new _3D_Point(4, 5, 6);
            //points[2] = new _3D_Point(1, 0, 3);
            //points[3] = new _3D_Point(2, 2, 2);
            //points[4] = new _3D_Point(0, 1, 1);

            //Console.WriteLine("Points before sorting:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}
            //points = _3D_Point.SortPoints(points);
            //Console.WriteLine("Points after sorting:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //#endregion 1.5_test

            #endregion project 1

            #region project 2

            //int a = 10, b = 0;
            //Console.WriteLine($"Sum of {a} and {b} : {project_2.Maths.sum(a, b)}");
            //Console.WriteLine($"Subtracting {b} and {a} : {project_2.Maths.subtract(a, b)}");
            //Console.WriteLine($"Multiplying {a} and {b} : {project_2.Maths.multiply(a, b)}");
            //Console.WriteLine($"Dividing {a} and {b} : {project_2.Maths.divide(a, b)}");
            //double x = 10.5, y = 2.5;
            //Console.WriteLine($"Sum of {x} and {y} is: {project_2.Maths.sum(x, y)}");

            #endregion project 2

            #region project 3

            #region 3.3

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            //Output: Hours: 1, Minutes: 10, Seconds: 15
            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());
            //Output: Hours: 1, Minutes: 0, Seconds: 0
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            //Output: Hours: 2, Minutes: 10, Seconds: 0
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());
            //Output: Minutes: 11, Seconds: 6

            #endregion 3.3

            #region 3.4

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = ++D1;
            D3 = --D2;
            D1 = D1 - D2;
            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else
            {
                Console.WriteLine("D1 is not greater than D2");
            }
            if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }
            else
            {
                Console.WriteLine("D1 is greater than D2");
            }
            if (D1)
            {
                Console.WriteLine("D1 is not zero");
            }
            else
            {
                Console.WriteLine("D1 is zero");
            }
            DateTime Obj = (DateTime)D1;

            #endregion 3.4
            #endregion

        }
    }
}
