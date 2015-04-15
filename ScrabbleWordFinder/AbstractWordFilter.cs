using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrabbleWordFinder.Filters
{
    public abstract class AbstractWordFilter : IWordFilter
    {
        public List<String> ApplyRule(List<String> AllWords)
        {
            var MatchingWords = new List<String>();
            foreach (string word in AllWords)
            {
                if (isValid(word))
                    MatchingWords.Add(word);
            }

            return MatchingWords;
        }

        public abstract bool isValid(string word);
    }
}
