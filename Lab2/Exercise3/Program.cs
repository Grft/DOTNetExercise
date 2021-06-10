using System;

namespace Exercise3
{
    class FindSquares
    {
        private static int FindRoot(int n)
        {
            int l = 0, r = 101, mid = 0;
            while (l <= r)
            {
                mid = (r - l) / 2 + l;
                if (mid * mid >= n && (mid - 1) * (mid - 1) < n)
                    break;
                if (mid * mid < n)
                {
                    l = mid + 1;
                    continue;
                }
                r = mid - 1;
            }

            return mid;
        }
        public static int Solution(int A, int B)
        {
            if (A > B)
                return 0;
            if (B < 0)
                return 0;
            if (A < 0)
                A = 0;

            return FindRoot(B) - FindRoot(A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("there are " + FindSquares.Solution(A, B) + " squares");

        }
    }
}
