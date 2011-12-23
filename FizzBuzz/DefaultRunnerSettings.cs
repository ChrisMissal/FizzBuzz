using System.Collections.Generic;

namespace FizzBuzz
{
    public class DefaultRunnerSettings : IRunnerSettings
    {
        private readonly IDictionary<int, string> replacements = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"},
        };

        public IDictionary<int, string> Replacements
        {
            get { return replacements; }
        }
    }
}