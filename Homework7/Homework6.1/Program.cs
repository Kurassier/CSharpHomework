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
                    case 3:
                        Console.Clear();
                        orderService.Change();
                        break;
                    case 4:
                        Console.Clear();
                        orderService.Delete();
                        break;
                    case 5:
                        Console.Clear();
                        orderService.FindWithAmount();
                        break;
                    case 6:
                        Console.Clear();
                        orderService.Export();
                        break;
                    case 7:
                        Console.Clear();
                        orderService.Import();
                        break;
                }
                index = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
