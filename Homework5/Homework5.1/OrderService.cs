using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            var selected = from item in list where 
                           item.GetData(0).Contains(input) ||
                           item.GetData(1).Contains(input) ||
                           item.GetData(2).Contains(input)
                           select item;
            foreach(Order order in selected)
            {
                order.Output();
            }
        }

        public void FindWithAmount()
        {
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            var selected = from item in list
                           where
                           item.GetAmount() > input
                           select item;
            foreach (Order order in selected)
            {
                order.Output();
            }
        }

        public void Delete()
        {
            string input;
            input = Console.ReadLine();
            Console.Clear();
            var selected = from item in list
                           where
         item.GetData(0).Contains(input) ||
         item.GetData(1).Contains(input) ||
         item.GetData(2).Contains(input)
                           select item;
            foreach (Order order in selected)
            {
                list.Remove(order);
            }
        }


        public void Change()
        {
            string input;
            input = Console.ReadLine();
            Console.Clear();
            var selected = from item in list
                           where
         item.GetData(0).Contains(input) ||
         item.GetData(1).Contains(input) ||
         item.GetData(2).Contains(input)
                           select item;
            foreach (Order order in selected)
            {
                order.SetData();
            }
        }


    }
}
