using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose of hte following options:");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");

            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q - Quit");

            ConsoleKeyInfo userChoise = Console.ReadKey(true);
            Console.WriteLine("you chose " + userChoise);

            var x = userChoise.Key;
            char y = userChoise.KeyChar;
            var z = userChoise.Modifiers;

            Console.WriteLine("Key = " + x);
            Console.WriteLine("KeyChars = " + y);
            Console.WriteLine("Modifiers = " + z);

        }
    }
}
