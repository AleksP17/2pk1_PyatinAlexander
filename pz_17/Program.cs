using System;
using System.IO;


namespace pz_17
{
    class Program
    {
        public static int[] Geom(int n)
        {
            int[] A = new int[n];
            int i;
            for (i = 0; i < n; i++)
                A[i] = 10 * 2 ^ (n - 1);
            return A;
        }
            
        
        static void Main(string[] args)
        {
            Console.WriteLine("Геометрический массив:");
            Geom(7);
            


        }
    }
}
