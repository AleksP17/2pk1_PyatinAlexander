using System;

namespace pz_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var app1 = new Track("Алексей Фролов");
            app1.GetInfo();
            Console.WriteLine();

            var app2 = new Track("Вадим Казаков");
            app2.GetInfo();
            Console.WriteLine();

            var app3 = new Track("Сергей Музыченко", "Рыба", "Аквариум",2000,23,"FLAC");
            app3.GetInfo();
            Console.WriteLine();

            var app4 = new Track("Денис Дрозд", "Птичка", "Скворечник", 1990, 55,"ASS");
            app4.GetInfo();
            Console.WriteLine();

            var app5 = new Track("Иван Берёза", "Куст", "Лес", 2023, 249, "MP2");
            app5.GetInfo();
            Console.WriteLine();
        }
    }
}
