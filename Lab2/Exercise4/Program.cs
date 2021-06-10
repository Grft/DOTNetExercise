using System;

namespace Exercise4
{
    class Print2DArray
    {
        public void Solution()
        {
            Console.Write("enter X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[Y, X];
            bool[,] visited = new bool[Y, X];
            for (int i = 0; i < Y; i++)
            {
                Console.WriteLine("enter the " + i + "th line of matrix from left to right");
                for (int j = 0; j < X; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    visited[i, j] = false;
                }
            }
            int total = X * Y;
            int xNow = 0, yNow = 0, xNext = 1, yNext = 0, tmp;
            for (int i = 0; i < total; i++)
            {
                Console.Write(matrix[yNow, xNow] + " ");
                visited[yNow, xNow] = true;
                if (visited[(yNow+yNext+Y) % Y, (xNow+xNext+X) % X])
                {
                    tmp = -yNext;
                    yNext = xNext;
                    xNext = tmp;
                }
                yNow += yNext;
                xNow += xNext;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Print2DArray p = new Print2DArray();
            p.Solution();
        }
    }
}
