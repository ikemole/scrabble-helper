using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrabbleWordFinder.Filters
{
    public interface IWordFilter
    {
        ///<summary>
        ///Apply a filter rule to the input list.
        ///Remove words from the list if they dont obey the rule. 
        /// </summary>
        List<String> ApplyRule(List<String> AllWords);

        ///<summary>
        ///This method defines a rule that a word must obey.
        /// </summary>
        bool isValid(String word);
    }
}
