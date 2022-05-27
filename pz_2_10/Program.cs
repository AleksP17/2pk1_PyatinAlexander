using System;

namespace pz_2_10
{
        struct TRAIN
        {
            public string NAZN;
            public int NUMR;
            public string TIME;
            public TRAIN(string n, string t, int nu)
            {
                NAZN = n;
                NUMR = nu;
                TIME = t;
            }
            public override string ToString() => $"Номер - {NUMR}\nПункт назначения - {NAZN}\nВремя - {TIME}";
        }
    internal class Program
    {
         static void sortInd(ref TRAIN[] RASP)
         {
                for (int i = 0; i < RASP.Length; i++)
                {
                    for (int y = i + 1; y < RASP.Length; y++)
                    {
                        if (RASP[i].NUMR > RASP[y].NUMR)
                        {
                            (RASP[i], RASP[y]) = (RASP[y], RASP[i]);
                        }
                    }
                }

         }
        static void Main(string[] args)
        {
            TRAIN[] RASP = new TRAIN[8];

            for (int i = 0; i < RASP.Length; i++)
            {
                Console.Write("Номер поезда: ");
                int nu = int.Parse(Console.ReadLine());
                Console.Write("Название пункта назначения поезда: ");
                string n = Console.ReadLine();
                Console.Write("Время отправления поезда: ");
                string t = Console.ReadLine(); ;
                RASP[i] = new TRAIN( n , t, nu);
            }
            sortInd(ref RASP);
            Console.Write("Какой поезд вы хотите найти?\nНомер поезда: ");
            int num = int.Parse(Console.ReadLine());
                for (int i = 0; i < RASP.Length; i++)
                {
                    if (RASP[i].NUMR == num)
                    {
                        Console.WriteLine($"Поезд найден: {RASP[i]}");
                        break;
                    }
                    else if (i == RASP.Length - 1)
                    {
                        Console.WriteLine("Незарегистрированный поезд!!!");
                    }
                }
           
        }

    }
}
