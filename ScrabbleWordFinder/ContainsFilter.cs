using ScrabbleWordFinder.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ScrabbleWordFinder.Filters
{
    public class ContainsFilter : AbstractWordFilter
    {
        private List<String> listOfStringsAWordMustContain;

        ///<summary>
        ///The parameter could be a single sequence
        ///or several sequences delimited by commas
        /// </summary>
        public ContainsFilter(String commaSeparatedString)
        {
            this.listOfStringsAWordMustContain = split(commaSeparatedString);
        }

        public override bool isValid(String word)
        {
            word = word.ToUpper();
            foreach (String seq in listOfStringsAWordMustContain)
            {
                if (!word.Contains(seq))
                    return false;
            }
            return true;
        }

        private List<String> split(String commaSeparatedString)
        {
            commaSeparatedString = commaSeparatedString.ToUpper().Trim();
            String[] strings = commaSeparatedString.Split(',');
            List<String> validatedStrings = new List<string>(1);
            foreach (String str in strings)
            {
                string s = str.Trim();

                if (containsOnlyAlphabets(s))
                    validatedStrings.Add(s);
                else
                    throw new ApplicationException("The string '" + str + "' is not valid.");
            }
            return validatedStrings;
        }

        private bool containsOnlyAlphabets(String str)
        {
            string regexMatchSingleWord = "[a-zA-Z]+";
            Match match = Regex.Match(str, regexMatchSingleWord);
            return match.Success;
        }

    }
}
