using System;

namespace Inheritance
{
    class Person
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
    }

    class Student : Person
    {
        public Student(string nm)
        {
            Name = nm;
        }

        public void Speak()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}
