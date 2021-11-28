using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\File1.txt", FileMode.Open);
            StreamWriter writer = new StreamWriter(file);
            Console.WriteLine("Массив А:");
            int i, j;
            int[,] A = new int[5, 8];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    A[i, j] = i * j;
                    Console.Write(A[i, j] + " ");
                }
                
            }
            writer.WriteLine();
            writer.Close();
        }
    }
}
