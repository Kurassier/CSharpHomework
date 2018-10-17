using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4._2
{
    class Order
    {
        private OrderDetails details;
        public Order(string number, string item, string costumer)
        {
            details = new OrderDetails();
            details.number = number;
            details.item = item;
            details.costumer = costumer;
        }
        public void SetData()
        {
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
            details.number = array[0];
            details.item = array[1];
            details.costumer = array[2];
            details.amount = Convert.ToInt32(array[3]);
        }
        public string GetNumber()
        {
            return details.number;
        }
        public string GetCostum()
        {
            return details.costumer;
        }
        public string GetItem()
        {
            return details.item;
        }
        public string GetData(int i)
        {
            switch (i)
            {
                case 0:
                    return details.number;
                case 1:
                    return details.number;
                case 2:
                    return details.number;
            }
            return null;
        }
        public int GetAmount()
        {
            return details.amount;
        }
        public void Output()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Index:" + details.number);
            Console.WriteLine("Item:" + details.item);
            Console.WriteLine("Costumer:" + details.costumer);
        }

    }
}
