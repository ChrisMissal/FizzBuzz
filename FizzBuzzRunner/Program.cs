using System;
using FizzBuzz;
using FizzBuzzRunner.Configuration;

namespace FizzBuzzRunner
{
    class Program
    {
        private static readonly IRunnerSettings settings = new AppConfigRunnerSettings();
        private static readonly Runner runner = new Runner(settings);

        static void Main(string[] args)
        {
            foreach (var line in runner.Run(1, 100))
            {
                Console.Write(line + "  ");
            }
        }
    }
}
