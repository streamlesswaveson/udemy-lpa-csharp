using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string apples = "apples";
            int appleQuantity = 8;
            int applePrice = 100;
            string oranges = "oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string col1Heading = "Fruit";
            string col2Heading = "Quantity";
            string col3Heading = "Price";

            const int  col1Space = -12;
            const int col2Space = 8;
            const int col3Space = 6;

            // The ':C' is a currency formatter
            Console.WriteLine($"{col1Heading, col1Space} {col2Heading, col2Space} {col3Heading, col3Space}");
            Console.WriteLine($"{apples, col1Space} {appleQuantity, col2Space} {applePrice/100.0, col3Space:C}");
            Console.WriteLine($"{oranges, col1Space} {orangeQuantity, col2Space} {orangePrice/100.0, col3Space:C}");

            Console.WriteLine($"Math.PI={Math.PI}");

            Console.WriteLine($"Math.PI={Math.PI:F3}");
            Console.WriteLine($"Math.PI={Math.PI:F0}");

            Console.WriteLine($"Math.PI={Math.PI:F12}");
            Console.WriteLine($"Math.PI={Math.PI:F99}");

        }
    }
}
