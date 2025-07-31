using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q1
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double area { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            area = 3.14 * radius * radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Area: {area}");
        }
    }
    
}
