using System;
namespace TechnicalTestCore
{
    internal class FizzBuzz
    {
        public static void PrintFizzBuzzStyleIntegersFrom1Till(string[] args)
        {
            int userInput = 0;
            Int32.TryParse(args[0], out userInput);

            for (int i = 1; i <= userInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    continue;
                }
                System.Console.WriteLine(i);

                // Write a method body which makes the corresponding unit test in the 'TechnicalTestUnitTest' project pass
                // For this to happen the method needs to do the following:
                // -- It prints the integers from 1 till args[0] to the screen
                // -- One integer per line
                // -- For every multiple of three print 'Fizz'
                // -- For every multiple of five print 'Buzz'
                // -- For every multiple of both three and five print 'FizzBuzz'

            }
        }
    }
}