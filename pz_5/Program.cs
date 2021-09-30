using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nЗадание 1:");
            int k;
            for (k = 10;k <= 70;k+=5)
            Console.WriteLine(k);
            {
                Console.WriteLine("\nЗадание 2:");
                char a = 'Г' ;
                char b = 'К' ;
                for (; a <= b; a++)
                {
                    Console.WriteLine(a.ToString());
                }
                Console.WriteLine("\nЗадание 3:");
                 int n = 4;
                 int m = 9;
                for (m = 0; m <= 9; m++)
                {
                  for (n = 0; n <= 4; n++)
                 Console.Write("#");
                  Console.WriteLine();
                }
                    
                Console.WriteLine("\nЗадание 4:");
                for (int c = 0;  c <= 100; c++)
                {
                 if (c == 0) continue;
                 if ((c % 4) != 0) continue;
                 Console.Write(" " + c);
                 Console.WriteLine();           
                }
            } 
           Console.WriteLine("\nЗадание 5:");
            int i = 5;
            int j = 64;
            for ( i = 5, j = 64; j - i > 23; i++, j--)
            {
             Console.WriteLine("i и j равны:" +i+ "и" +j);
            }
        }



    }       
}
