using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Circle : Shape
    {
        public double side;

        public Circle(double radius){
            area = radius * radius * 3.14;
        }
        public override void getArea()
        {
            Console.WriteLine("The area of the Circle is "+area+".");
        }
    }
}
