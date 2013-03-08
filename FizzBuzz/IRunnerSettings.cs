using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IRunnerSettings
    {
        IDictionary<int, Replacement> Replacements { get; }
    }
}