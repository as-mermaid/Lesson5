using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ",array[i]);
            }

            int min = array[0];
            int max = array[0];

            for (int i = 1;i < 15; i++)
            {
                if (array[i] < min) 
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Сумма минимального ({0}) и максимального ({1}) числа равна {2}", min, max, min+max);
            Console.ReadKey();
        }
    }
}

