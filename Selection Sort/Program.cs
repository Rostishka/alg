using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int max;

            Random rand_num = new Random();

            Console.Write("Unsorted array: ");
            for (int i = 0; i < array.Length; i++)//generating array
            {
                array[i] = rand_num.Next(1, 101);
            }

            for (int i = 0; i < array.Length; i++)//Output unsorted array
                Console.Write(array[i] + " ");


            Console.WriteLine();
            Console.WriteLine();

            for(int i = 0; i < array.Length - 1; i++)
            {
                int imin = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[imin])
                    {
                        imin = j;
                    }
                    int temp = array[i];
                    array[i] = array[imin];
                    array[imin] = temp;
                }           
            }

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)//Output sorted array
                Console.Write(array[i] + " ");

            

            Console.ReadKey();
        }
    }
}
