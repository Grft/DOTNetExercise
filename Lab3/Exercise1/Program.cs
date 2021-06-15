using System;

namespace Exercise1
{
    abstract class Shape1
    {
        protected float R, L, B;

        public abstract float Area();
        public abstract float Circumference();
    }

    class Rectangle1 : Shape1
    {
        public void GetLB()
        {
            Console.Write("Enter Length: ");

            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth: ");

            B = float.Parse(Console.ReadLine());
        }


        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle1 : Shape1
    {

        public void GetRadius()
        {
            Console.Write("Enter Radius: ");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return 3.14F * R * R;
        }
        public override float Circumference()
        {
            return 2 * 3.14F * R;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle1 R = new Rectangle1();
            R.GetLB();
            Console.WriteLine("Area: " + R.Area());
            Console.WriteLine("Circumference: " + R.Circumference());

            Console.WriteLine();

            Circle1 C = new Circle1();
            C.GetRadius();
            Console.WriteLine("Area: " + C.Area());
            Console.WriteLine("Circumference: " + C.Circumference());
        }
    }
}
