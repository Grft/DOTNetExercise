using System;

namespace Exercise1
{
    class Rectangle
    {
        private double length = 1, width = 1;
        public void GetData()
        {
            while(true)
            {
                Console.WriteLine("enter length:");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter width:");
                width = Convert.ToDouble(Console.ReadLine());
                if (length < 0 || length > 20 || width < 0 || width > 20)
                {
                    Console.WriteLine("len and wid should in [0, 20]");
                    continue;
                }
                break;
            }
        }
        private double GetArea()
        {
            return length * width;
        }

        private double GetPerimeter()
        {
            return (length + width) * 2;
        }

        public void Display()
        {
            Console.Write("Length: ");
            Console.WriteLine(length);
            Console.Write("Width: ");
            Console.WriteLine(width);
            Console.Write("Area: ");
            Console.WriteLine(GetArea());
            Console.Write("Length: ");
            Console.WriteLine(GetPerimeter());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetData();
            r.Display();
            Console.ReadLine();
        }
    }
}
