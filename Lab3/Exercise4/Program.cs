using System;

namespace Exercise4
{
    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Student: Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", base.age);
        }
    }

    class Teacher: Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
