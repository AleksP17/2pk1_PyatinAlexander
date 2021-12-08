using System;
using System.Linq;
namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "ДОЖДЬ МАШИНА ОКНО ДВЕРЬ ДИВАН СТУЛ КОШКА ";
            var result = str.Split().Count(x => x.Contains('А'));
            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
