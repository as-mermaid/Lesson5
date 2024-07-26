using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }

            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
