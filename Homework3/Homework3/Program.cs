using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Triangle(2, 4);
            shapes[1] = new Circle(3);
            shapes[2] = new Rectangle(2, 4);
            shapes[3] = new Square(2);
            for(int i = 0; i < 4; i++){
                shapes[i].getArea();
            }
            Console.ReadKey();
        }
    }
}
