using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите v: ");
            double v = Double.Parse(Console.ReadLine());


            double s = 0, p = 0;
            if (y < 0.5)
            {
                s = (x / (1 + y * x)) + 2 * y;

            }

            else if (y >= 0.5)
            {
                s = Math.Pow(y, 2) + Math.Pow(x, 2) - Math.Cos(x + 1.5);

            }
            Console.WriteLine(s);
            if (x <= 0)
            {
                p = (s / Math.Abs(x + 3)) + ((12 * s) / Math.Abs(Math.Pow(y, 2) + 7));

            }
            else if (x > 0)
            {
                p = (x * y + 1.5 * y) / Math.Sin(Math.PI - s);

            }
            Console.WriteLine(p);
            double g = (Math.Cos(p + s)) / (Math.Pow(y, 2) + Math.Pow(v, 2));
            Console.WriteLine(g);
        }
    }
}
