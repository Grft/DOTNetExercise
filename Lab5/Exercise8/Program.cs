using System;

namespace Exercise8
{
    class A
    {
        int x;
        //public abstract void F(int n);
        /*private virtual void G(unsigned n)
        {
            x = n as int;
        }*/
        public override string ToString()
        {
            return x.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
