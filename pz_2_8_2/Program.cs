using System;

namespace pz_2_8_2
{
    delegate void MyDel(char v);
    class Program
    {
        public char some;

        class MyClass
        {
            public char some;

            public void MyMethod(char v )
            {
                some = v;
            }
        }
        static void Main(string[] args)
        {
            var array = new MyClass[3] { new MyClass(), new MyClass(), new MyClass() };
            MyDel del = null;
            foreach (var item in array)
            {
                del += item.MyMethod;
            }
            char v = 'D';
            del(v);
            foreach (var item in array)
            {
                Console.WriteLine(item.some);
            }
            Console.ReadKey();
        }
    }
    
}
