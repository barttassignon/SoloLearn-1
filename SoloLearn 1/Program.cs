using System;

namespace SoloLearn_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            foreach (var item in words)
            {
                if (item.Contains(letter))
                {
                    Console.WriteLine(item);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
