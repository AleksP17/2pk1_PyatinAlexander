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
                else
                    return Geom(n - 1) * 2;
            }
        
            
        
        static void Main(string[] args)
        {
            
            for (int i = 1; i < Geom(4); i++)
                Console.WriteLine(Geom(i));
            Console.ReadLine();
        }
    }
}
