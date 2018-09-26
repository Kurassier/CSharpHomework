using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Rectangle : Shape
    {
        public double width;
        public double height;

        public Rectangle(double width, double height){
            area = width * height;
            this.width = width;
            this.height = height;
        }
        public override void getArea()
        {
            Console.WriteLine("The area of the Rectangle is " + area+".");
        }
    }
}
