using System;
using System.IO;


namespace pz_17
{
    class Program
    {
        public static int Geom(int n)
        {
            if (n == 1)
                return 1;
            
                return Geom(10 * 2 ^ (n - 1));
        }
            
        
        static void Main(string[] args)
        {
            
            Console.WriteLine(Geom(2));
           
        }
    }
}
