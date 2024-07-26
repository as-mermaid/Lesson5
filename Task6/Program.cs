using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, n];

            //Заполнение массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите значения {i + 1}-й строки массива");
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Вывод итогового массива
            Console.WriteLine("--------------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Проверка магического квадрата
            int sum0 = 0;
            bool isMagic = true;

            // Сумма 1 строки для сравнения
            for (int j = 0; j < n; j++)
            {
                sum0 += array[0, j];
            }

            // Суммы строк и сравнение
            for (int i = 1; i < n; i++)
            {
                int sumI = 0;
                for (int j = 0; j < n; j++)
                {
                    sumI += array[i, j];
                }
                if (sumI != sum0)
                {
                    isMagic = false;
                    break;
                }
            }

            // Суммы столбцов и сравнение
            if (isMagic)
            {
                for (int j = 0; j < n; j++)
                {
                    int sumJ = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sumJ += array[i, j];
                    }
                    if (sumJ != sum0)
                    {
                        isMagic = false;
                        break;
                    }
                }
            }

            // Сумма главной диагонали и сравнение
            if (isMagic)
            {
                int sumD1 = 0;
                for (int i = 0; i < n; i++)
                {
                    sumD1 += array[i, i];
                }
                if (sumD1 != sum0)
                {
                    isMagic = false;
                }
            }

            // Сумма побочной диагонали и сравнение
            if (isMagic)
            {
                int sumD2 = 0;
                for (int i = 0; i < n; i++)
                {
                    sumD2 += array[i, n - i - 1];
                }
                if (sumD2 != sum0)
                {
                    isMagic = false;
                }
            }

            // Вывод результата проверки
            Console.WriteLine();
            if (isMagic)
            {
                Console.WriteLine("Это магический квадрат");
            }
            else
            {
                Console.WriteLine("Это не магический квадрат");
            }

            Console.ReadKey();
        }
    }
}
