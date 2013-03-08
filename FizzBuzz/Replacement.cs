using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Replacement
    {
        /*private readonly KeyValuePair<int, string> _replacement;

        public Replacement(int @int, string @string)
        {
            _replacement = new KeyValuePair<int, string>(@int, @string);
        }*/

        public int Key { get; set;  }

        public string Value { get; set; }

        /*public override int GetHashCode()
        {
            return _replacement.GetHashCode();
        }*/
    }
}