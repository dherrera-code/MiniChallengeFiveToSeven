using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniCh5.Services
{
    public class ReverseItNumsOnlyService
    {
        // 4. ReverseIt (Numbers Only): endpoint that accepts a sequence of only numbers and reverses them.  Be sure to display the original characters before the reversed.  For example:
        //      - "You entered 12345, reversed is 54321"
        public string ReverseItNums(string sequence)
        {
            if(sequence.Length < 2) return "Invalid Input: Please enter more than one number!";
            if(!long.TryParse(sequence, out long numbers))
            {
                return "Invalid Input: Please enter a sequence of numbers only";
            }
            char[] reverseSequence = new char[sequence.Length];
            for(int i = 0; i < sequence.Length; i++)
            {
                reverseSequence[i] = sequence[sequence.Length - 1 - i];
            }
            string newSequence = string.Join("", reverseSequence);
            return $"You entered {sequence} and the reverse is {newSequence}";
        }
    }
}