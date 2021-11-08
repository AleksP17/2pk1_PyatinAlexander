using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //создание ступенчатого массива
            char[][] arr = new char[4][];

            arr[0] = new char[rand.Next(2, 10)];
            arr[1] = new char[rand.Next(2, 10)];
            arr[2] = new char[rand.Next(2, 10)];
            arr[3] = new char[rand.Next(2, 10)];

            int firstАlphаNum = Convert.ToInt32('2');
            int lastАlphаNum = Convert.ToInt32('9');

            //заполнение массива рандомными символами
            for (int y = 0; y < arr.Length; y++)
            {
                for (int x = 0; x < arr[y].Length; x++)
                {
                    arr[y][x] = Convert.ToChar(rand.Next(firstАlphаNum, lastАlphаNum + 1));
                }
            }

            //вывод массива
            Console.WriteLine("Ступенчатый массив");

            foreach (char[] row in arr)
            {
                foreach (char symbol in row)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }

            //массив последних элементов зубчатого массива
            char[] lastVals = new char[arr.Length];

            for (int i = 0; i < lastVals.Length; i++)
            {
                lastVals[i] = arr[i][^1];
            }

            //вывод элементов массива lastVal
            Console.Write("\nПоследние элементы каждой строки: ");
            foreach (char ch in lastVals)
            {
                Console.Write($"{ch} ");
            }

            //массив старших элементов каждой строки
            char[] maxVals = new char[arr.Length];

            for (int i = 0; i < maxVals.Length; i++)
            {
                char maxChar = arr[i][0];
                for (int k = 0; k < arr[i].Length; k++)
                {
                    if (arr[i][k] > maxChar)
                        maxChar = arr[i][k];
                }
                maxVals[i] = maxChar;
            }

            Console.Write("\nСтаршие элементы каждой строки: ");
            foreach (char ch in maxVals)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();

            //Смена местами старших и первых элементов массива
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i][Array.IndexOf(arr[i], maxVals[i])] = arr[i][0];
                arr[i][0] = maxVals[i];
            }

            Console.WriteLine("\nОбновлённый массив");
            foreach (char[] row in arr)
            {
                foreach (char ch in row)
                {
                    Console.Write($"{ch} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
