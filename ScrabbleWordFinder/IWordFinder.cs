using System;
using System.Collections.Generic;

namespace ScrabbleWordFinder
{
    /// <summary>
    /// This represents the functions of a class that is 
    /// used to find words using the user's tiles.
    /// The approach may be different depending on the dictionary being used.
    /// </summary>
    public interface IWordFinder
    {
        ///<summary>
        ///Find words that can be formed using the tiles.
        /// </summary>
        List<String> findWords(String tiles);

    }
}
