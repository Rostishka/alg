using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортування_булькою
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 152, 43, 65, 13, 55, 4, 12, 2, 170, 30 };
            int wz;

                for(int i = 0; i < array.Length; i++)//Output starter array
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)//Cycle of Bubble sorting
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        wz = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = wz;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)//Output sorted array
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}

