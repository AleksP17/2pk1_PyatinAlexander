using System;


namespace pz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            result = Math.Pow(14 + Math.Pow(8 - 1, 1/3), 1/4) / Math.Abs(8 - 14) * (Math.Pow(Math.Sin(Math.PI/4), 2) + Math.Tan(Math.PI/4));
            Console.WriteLine(result);
        }
    }
}
