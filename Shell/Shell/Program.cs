using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 1, 6, 7, 3, 25, 43, 7, 82 };
            int temp, b;
            
            for (int i = 0; i < array.Length; i++)
            {
                int D = array.Length / 2;
                for (int j = 0; j < array.Length; j ++)
                {
                    if (array[j] > array[j + D])
                    {
                        temp = array[j];
                        array[j + D] = array[j];
                        array[j] = temp;
                    }
                }
            }
           Console.ReadKey();
        }
    }
}
