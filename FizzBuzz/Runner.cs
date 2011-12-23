using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Runner
    {
        private readonly IDictionary<int, string> replacements;

        public Runner(IRunnerSettings runnerSettings)
        {
            replacements = runnerSettings.Replacements ?? new Dictionary<int, string>();
        }

        public IEnumerable<string> Run(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                yield return GetLine(i);
            }
        }

        public string GetLine(int value)
        {
            var line = GetReplacements(value).Aggregate("", (current, replacement) => current + replacement);
            return line == "" ? value.ToString() : line;
        }

        private IEnumerable<string> GetReplacements(int value)
        {
            return replacements.Where(entry => value % entry.Key == 0).Select(entry => entry.Value);
        }
    }
}
