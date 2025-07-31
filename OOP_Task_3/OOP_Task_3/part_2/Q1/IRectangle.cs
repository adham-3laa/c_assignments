using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_3.part_2.Q1
{
    internal interface IRectangle : IShape
    {
        int Length { get; set; }
        int Width { get; set; }
    }
}
