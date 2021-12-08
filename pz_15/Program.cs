using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\File1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Массив А:");
            int i, j;
            int[,] A = new int[5, 8];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    A[i, j] = i * j;
                    writer.Write(A[i, j] + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
            writer.Close();
            
        }
    }
}
