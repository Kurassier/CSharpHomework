using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Triangle : Shape
    {
        public double width;
        public double height;

        public Triangle(double width, double height){
            area = width * height / 2;
            this.width = width;
            this.height = height;
        }
        public override void getArea()
        {
            Console.WriteLine("The area of the Triangle is " + area+".");
        }
    }
}
