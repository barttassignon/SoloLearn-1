using System;

namespace SoloLearn_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());


            double output = pi * (radius * radius);
            Console.WriteLine(output);
        }

    }
}
