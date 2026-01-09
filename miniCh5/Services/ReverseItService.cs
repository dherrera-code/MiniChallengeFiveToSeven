using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniCh5.Services
{
    public class ReverseItService
    {
        //  ReverseIt (Alphanumeric): endpoint that accepts a sequence of numbers and letters then reverses them.  For example:
        //      - "You entered 123ABC, reversed is CBA321"
        public string ReverseItAlphaNum(string sequence)
        {

            if(sequence.Length < 2)
            {
                return "Invalid character count, Please input multiple characters!";
            }

            char[] reverseSequence = new char[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                reverseSequence[i] = sequence[sequence.Length - 1 - i];
            }

            string newSequence = string.Join("", reverseSequence);
            return $"You entered {sequence} and the reverse is {newSequence}";
        }
    }
}