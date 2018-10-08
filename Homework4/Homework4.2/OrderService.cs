using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4._2
{
    class OrderService
    {
        List<Order> list = new List<Order>();

        public void Add()
        {
            Console.Clear();
            string input;
            input = Console.ReadLine();
            Console.Clear();

            int i = 0, j = 0;
            string[] array = new string[100];
            string x = null;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    x = x + input[i];
                }
                else
                {
                    array[j] = x;
                    j++;
                    x = null;
                }
                i++;
            }
            array[j] = x;
            j++;

            list.Add(new Order(array[0], array[1], array[2]));
        }

        public void Find()
        {
            string input;
            input = Console.ReadLine();
            Console.Clear();
            foreach (Order var in list)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        var.Output();
                        break;
                    } 
                }
            }
        }


        public void Delete()
        {
            string input;
            input = Console.ReadLine();
            Console.Clear();
            foreach (Order var in list)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        list.Remove(var);
                        break;
                    }
                }
            }
        }


        public void Change()
        {
            string input;
            input = Console.ReadLine();
            Console.Clear();
            foreach (Order var in list)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (var.GetData(i).Contains(input))
                    {
                        var.SetData();
                        break;
                    }
                }
            }
        }


    }
}
