using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q1
{
    public class Rectangle1 : IRectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public double area { get; set; }
        public Rectangle1(int length, int width)
        {
            Length = length;
            Width = width;
            area = length * width;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Area: {area}");
        }
    }
  
}
