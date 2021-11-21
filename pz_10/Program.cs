using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // Инициализация массива строк
            string[] daysOfWeek = [rand.Next(2,10)];

            // Вывод массива строк AS в цикле
            for (int i = 0; i < daysOfWeek.Length; i++)
                Console.WriteLine("[{0}] = {1}", i, daysOfWeek[i]);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
        
    


        
    

