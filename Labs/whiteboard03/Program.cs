using System;

namespace whiteboard03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int e = 4;
            int len = a.Length + 1;
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (e > a[i])
                    result[i] = a[i];
                else if (e < a[i])
                    result[i + 1] = a[i];
                else if (e == a[i])
                    result[i] = e;
                Console.WriteLine($"1: {i}, a[{i}]: {a[i]}, result[(i)]: {result[i]}");


            }
            foreach (int i in result) ;
        }
    }
}
