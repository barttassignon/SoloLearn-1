using System;

namespace Inheritance
{
    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}
