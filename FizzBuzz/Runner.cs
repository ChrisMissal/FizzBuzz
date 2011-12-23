using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Runner
    {
        public IEnumerable<string> Run(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                yield return GetLine(i);
            }
        }

        public string GetLine(int i)
        {
            var line = "";
            if (i % 3 == 0)
                line += "Fizz";
            if (i % 5 == 0)
                line += "Buzz";
            return line == "" ? i.ToString() : line;
        }
    }
}
