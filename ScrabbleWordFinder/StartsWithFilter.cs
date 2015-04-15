using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrabbleWordFinder.Filters
{
    public class StartsWithFilter : AbstractWordFilter
    {
        private String sequenceToFind;

        public StartsWithFilter(String sequenceToFind)
        {
            this.sequenceToFind = sequenceToFind.Trim().ToUpper();
        }

        public override bool isValid(String word)
        {
            word = word.ToUpper();
            return word.StartsWith(sequenceToFind);
        }

    }
}
