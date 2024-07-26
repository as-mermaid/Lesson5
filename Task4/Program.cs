using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            int k = 0;

            for (int i = 0; i < 20; i++)
            {
                if (array[i] % 2 != 0 && array[i] > 0 && i % 2 == 0)
                    k++;
            }

            Console.WriteLine();
            Console.WriteLine($"Количество нечетных положительных чисел на четных местах равно {k}");
            Console.ReadKey();
        }
    }
}
