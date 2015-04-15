using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrabbleWordFinder.Filters
{
    public class LengthFilter : AbstractWordFilter
    {
        private int minLength;
        private int maxLength;

        public LengthFilter(int expectedLength)
        {
            minLength = expectedLength;
            maxLength = expectedLength;
        }

        public LengthFilter(int min, int max)
        {
            minLength = min;
            maxLength = max;
        }

        public override bool isValid(String word)
        {
            word = word.ToUpper();
            return ( word.Length >= minLength && word.Length <= maxLength );
        }
    }
}
