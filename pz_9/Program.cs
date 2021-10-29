using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(4, 4);
            int[,] A = new int[r, r];
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(-10, 10);
                    A[i, j] = rand;
                }
            }
            Console.WriteLine("Матрица:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            long num = 0;
            for (int i = 0; i < r; i++)
                for (int j = 0; j <= i; j++)
                    if (A[i, j] < 0)
                    {
                        num = num + 1;
                    }
            Console.WriteLine($"Количество отрицательных элементов расположенных под главной диагональю:" + num);

            Console.ReadKey();
        }
    }
    
}
