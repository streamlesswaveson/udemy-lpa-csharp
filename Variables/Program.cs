using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
                
            int firstNumber = random.Next(2,10);
            int secondNumber = random.Next(2,10);

            // 'var' will infer the type
            var subtraction = random.Next(2,10);

            var answer = firstNumber * secondNumber - subtraction;
            string prompt = ". Press ENTER when ready";
            Console.WriteLine("think of a number between 1-10" + prompt);
            Console.ReadKey();
            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now multiply your number by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally thought of " + prompt);
            Console.ReadKey();
            Console.WriteLine("Now subtract " + subtraction + prompt);
            Console.ReadKey();

            Console.WriteLine("the answer is " + answer);

                }
    }
}
