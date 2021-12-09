using System;
using System.IO;


namespace pz_17
{
    class Program
    {
        public static int[] Geom(int n)
        {
            int[] Geom = new int[n];
            int i;
            for (i = 0; i < n; i++)
                Geom[i] = 10 * 2 ^ (n - 1);
            return Geom;
        }
            
        
        static void Main(string[] args)
        {
            Console.WriteLine(Geom(4));
            for (int i = 1; i < 8; i++)
                
            Console.ReadLine();



        }
    }
}
