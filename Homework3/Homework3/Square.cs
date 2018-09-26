using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Square : Shape
    {
        public double side;

        public Square(double side){
            area = side * side;
            this.side = side;
        }
        public override void getArea()
        {
            Console.WriteLine("The area of the square is "+area+".");
        }
        
    }
}
