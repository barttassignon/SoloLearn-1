namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            System.Console.WriteLine(d.Legs);
            d.Bark();

            Student s = new Student("David");
            s.Speak();

        }
    }
}
