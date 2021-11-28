using System;

namespace pz_17
{
    class Program
    {
        static public int[] Geom(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = 10 * 2 ^ (n - 1);

            return arr;
        }
        static void Main(string[] args)
        {
            Geom(5);
            int[] A;
            A = Geom(5);
        }
    }
}
