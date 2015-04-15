using System;

namespace ScrabbleWordFinder.Dictionary
{
    /// <summary>
    /// This represents the functions of a dictionary 
    /// to be used in a scrabble game.
    /// </summary>
    public interface IWordDictionary
    {
        void addWordAndMeaning(String word, String meaning);
        string getMeaning(String word);
        bool isCorrectWord(String word);
    }
}
