using System;

namespace Homework4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            int index;
            index = Convert.ToInt32(Console.ReadLine());
            while (index != 0)
            {
                switch (index)
                {
                    case 1:
                        Console.Clear();
                        orderService.Add();
                        break;
                    case 2:
                        Console.Clear();
                        orderService.Find();
                        break;
                }
                index = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
