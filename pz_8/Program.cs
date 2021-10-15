using System;
using System.Collections.Generic;
using System.Linq;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int i;
            int[] A = new int[n] { 5, 3, -1, 8, 0, -6, 1 };
            Console.WriteLine("Массив А:");
            for (i = 0; i <= n-1; i++)
                Console.Write($"{ A[i]}");
            Console.WriteLine();
            Console.WriteLine("Первое отрицательное число находится на {0} позиции",
            Array.IndexOf(A, A.Max((x) => Math.Abs(x))));

            long sum = 0;
            for (i = 0; i <= 0; i++)
            {
                sum =A.Max((x) => Math.Abs(x)) +Math.Abs(A[i]) + 2 ;
                Console.WriteLine("Сумма модулей=" +sum);
                Console.ReadLine();
            }
        }                                     
    }
}
