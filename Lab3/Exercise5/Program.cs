using System;

namespace Exercise5
{
    class ComplexNumber
    {
        private int r, i;

        public string ToString()
        {
            return "(" + r.ToString() + "," + i.ToString() + ")";
        }

        public void SetImaginary(int n)
        {
            i = n;
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(r * r + i * i);
        }

        public void Add(ComplexNumber number2)
        {
            r += number2.r;
            i += number2.i;
        }
        public ComplexNumber()
        {
            r = 0;
            i = 0;
        }

        public ComplexNumber(int r, int i)
        {
            this.r = r;
            this.i = i;
        }
    }

    class ComplexTest
    {
        static void Main()
        {
            bool debug = false;

            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    }
}
