using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pz_2_8_1

{
    delegate int Operation(char c, string s);
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            string s = "qwedaaa asvsss asfsf kkkkkk uuuau aaa";
            Operation del = Entrance;
            int result = del(c, s);
            Console.WriteLine(result);

            del = Index;
            result = del(c, s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static int Entrance(char c, string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c == s[i])
                    num++;
            }
            if (num == 0)
                return -1;
            return num;
        }
        private static int Index(char c, string s)
        {
            return s.IndexOf(c);
        }
    }
}

