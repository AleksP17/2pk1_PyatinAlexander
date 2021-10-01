using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            for (x = 1; x <= 4; x += 0.5)
            {
                double y = x + 3 * Math.Pow(x, 2) - 2.5 * Math.Pow(x, 3) +  0.75 * Math.Pow(x, 4);
                Console.WriteLine("{0:N}\t{1:N}", x, y);
            }
            Console.ReadKey();
        }
    }
}
