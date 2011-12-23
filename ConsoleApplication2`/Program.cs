using System;
using FizzBuzz;

namespace ConsoleApplication2_
{
    class Program
    {
        private static readonly Runner runner = new Runner();

        static void Main(string[] args)
        {
            foreach (var line in runner.Run(1, 100))
            {
                Console.WriteLine(line);
            }
        }
    }
}
