using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person p = new Person();
            p.SayHello();
            Student s = new Student();
            s.SetAge(21);
            s.SayHello();
            s.GoToClasses();
            s.ShowAge();
            Teacher t = new Teacher();
            t.SetAge(30);
            t.SayHello();
            t.Explain();
        }
    }
}
