using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IRunnerSettings
    {
        IDictionary<int, string> Replacements { get; }
    }
}