using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 1 - (i + j) % 2 ;
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
