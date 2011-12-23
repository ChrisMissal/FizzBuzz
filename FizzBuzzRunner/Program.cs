using System;
using FizzBuzz;

namespace FizzBuzzRunner
{
    class Program
    {
        private static readonly IRunnerSettings settings = new DefaultRunnerSettings();
        private static readonly Runner runner = new Runner(settings);

        static void Main(string[] args)
        {
            foreach (var line in runner.Run(1, 100))
            {
                Console.WriteLine(line);
            }
        }
    }
}
