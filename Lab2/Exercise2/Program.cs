using System;
using System.Collections.Generic;

namespace Exercise2
{
    class MostOftenValue
    {
        public int Solution(int[] A)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            int ans = 0, maxCount = 1;
            foreach (int num in A)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                    if (count[num] > maxCount)
                    {
                        maxCount = num;
                        ans = num;
                    }
                    continue;
                }
                count[num] = 1;
            }
            return ans;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MostOftenValue mov = new MostOftenValue();
            Console.Write("input size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("input array:");
            for (int i = 0; i < n; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("one of the most often value is: ");
            Console.WriteLine(mov.Solution(A));
        }
    }
}
