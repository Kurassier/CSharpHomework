using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace WindowsFormsApp1
{
    class OrderService
    {
        static List<Order> list = new List<Order>();

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

        public void Export()
        {
            FileStream fileStream = new FileStream(@"order.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            int i = 0;
            foreach (Order order in list)
            {
                order.OutputToFile(streamWriter, i);
                i++;
            }
            streamWriter.Close();
            fileStream.Close();
        }
        public void Import()
        {
            FileStream fileStream = new FileStream(@"order.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader streamReader = new StreamReader(fileStream);
            while (streamReader.ReadLine() != null)
            {
                string string1 = streamReader.ReadLine();
                string string2 = streamReader.ReadLine();
                string string3 = streamReader.ReadLine();
                string[] array;
                array = string1.Split(':');
                string1 = array[1];
                array = string2.Split(':');
                string2 = array[1];
                array = string3.Split(':');
                string3 = array[1];
                list.Add(new Order(string1, string2, string3));
            }
            streamReader.Close();
            fileStream.Close();
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
