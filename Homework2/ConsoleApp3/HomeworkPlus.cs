using System;

namespace Homework2
{
    class HomeworkPlus
    {
        static void Main(string[] args)
        {
            int[] array = new int[12] {1,2,3,4,5,6,7,8,9,10,11,12};
            int index = -1;
            for(int i = 0; i < 11; i++)
            {
                for (int j = 1; j < 5; j++) 
                {
                    index++;
                    if (index >= 12) index = 0;
                    if (array[index] == 0) j--;
                }
                array[index] = 0;
            }
            while (array[index] == 0)
            {
                index++;
                if (index >= 12) index = 0;
            }
            Console.WriteLine(array[index]);
            Console.ReadLine();

        }
    }
}
