using System;

namespace Exercise5
{
    class Box
    {
        private double length = 0, breadth = 0, height = 0;

        public double GetVolume()
        {
            return length * breadth * height;
        }

        public void SetLength(double len)
        {
            length = len;
        }
        public void SetBreadth(double bre)
        {
            breadth = bre;
        }
        public void SetHeight(double hei)
        {
            height = hei;
        }

        public static Box operator+ (Box a, Box b)
        {
            Box c = new Box();
            c.length = a.length + b.length;
            c.breadth = a.breadth + b.breadth;
            c.height = a.height + b.height;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box a = new Box();
            Box b = new Box();

            Console.Write("input length of A: ");
            a.SetLength(Convert.ToDouble(Console.ReadLine()));
            Console.Write("input breadth of A: ");
            a.SetBreadth(Convert.ToDouble(Console.ReadLine()));
            Console.Write("input height of A: ");
            a.SetHeight(Convert.ToDouble(Console.ReadLine()));
            
            Console.Write("input length of B: ");
            b.SetLength(Convert.ToDouble(Console.ReadLine()));
            Console.Write("input breadth of B: ");
            b.SetBreadth(Convert.ToDouble(Console.ReadLine()));
            Console.Write("input height of B: ");
            b.SetHeight(Convert.ToDouble(Console.ReadLine()));

            Box c = a + b;

            Console.WriteLine("volume of A: " + a.GetVolume());
            Console.WriteLine("volume of B: " + b.GetVolume());
            Console.WriteLine("volume of C: " + c.GetVolume());
        }
    }
}
