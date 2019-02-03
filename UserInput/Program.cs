using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string yourName = Console.ReadLine();
            Console.WriteLine($"your name is {yourName}");
            Console.WriteLine("how old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{yourName} is {age} years old");
        }
    }
}
