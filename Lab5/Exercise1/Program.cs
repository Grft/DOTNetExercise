using System;

namespace Exercise1
{
    class Program
    {
        static int PowerOfTwo(int n)
        {
            if (n == 0)
                return 1;
            else
                return PowerOfTwo(n - 1) << 1;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(PowerOfTwo(i) + " ");
            }
        }
    }
}
