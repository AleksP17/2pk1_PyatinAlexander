using System;

namespace pz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            double b = Double.Parse(Console.ReadLine());
            double c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
