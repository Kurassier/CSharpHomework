using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Alarm alarm = new Alarm();
            

            input = Console.ReadLine();


            int i = 0, j = 0;
            int[] array = new int[100];
            string x = null;
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    x = x + input[i];
                }
                else
                {
                    array[j] = Convert.ToInt32(x);
                    j++;
                    x = null;
                }
                i++;
            }
            array[j] = Convert.ToInt32(x);
            j++;


            alarm.SetAlarm(array[0], array[1], array[2]);
            Console.Clear();
            alarm.RunAlarm();
            Console.ReadLine();
        }

        
    }
}
