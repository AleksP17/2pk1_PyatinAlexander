using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\File.txt";
            string[] arr = File.ReadAllLines(s);
            for (int i = 0; i < arr.Length; i++)
            {
                char[] slime = arr[i].ToCharArray();
                Array.Sort(slime);
                arr[i] = String.Join("", slime);
            }
            File.WriteAllText(s, String.Join("\n", arr));
        }
    }
}

 
