using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrabbleWordFinder.Dictionary;
using System.Text.RegularExpressions;
using ScrabbleWordFinder.Filters;

namespace ScrabbleWordFinder
{
    public class WordFinderAdapter
    {
        private IWordFinder correctWordFinder;
        private ScrabbleSet scrabbleSet;

        public WordFinderAdapter(IWordFinder wordFinder, ScrabbleSet scrabbleSet)
        {
            this.correctWordFinder = wordFinder;
            this.scrabbleSet = scrabbleSet;
        }

        public List<String> getCorrectWords(String tiles)
        {
            tiles = tiles.ToUpper().Trim();

            if (UserInputIsValid(tiles))
            {
                List<String> correctWordsFromLetters = correctWordFinder.findWords(tiles);
                return correctWordsFromLetters;
            }
            else
            {
                throw new ApplicationException("Exception while parsing user input");
            }
        }

        public List<String> getCorrectWords(String tiles, List<IWordFilter> selectedRules)
        {
            List<String> correctWordsFromLetters = getCorrectWords(tiles);

            // Apply rules, if any
            foreach (IWordFilter rule in selectedRules)
            {
                correctWordsFromLetters = rule.ApplyRule(correctWordsFromLetters);
            }

            return correctWordsFromLetters;
        }


        public bool UserInputIsValid(String userInput)
        {
            /*
             * Must have only letters and BLANK characters
             */
            String reg1 = "^[A-Z" + ScrabbleSet.BLANK + "]+$";
            Match match = Regex.Match(userInput, reg1);
            if (!match.Success)
            {
                throw new ApplicationException("There are invalid characters in the tile set: " + userInput);
            }

            /*
             * Must have between 2 and 15 letters
             */
            int len = userInput.Length;
            if (len < 2 || len > 15)
            {
                throw new ApplicationException("The number of tiles must be between 2 and 15.");
            }

            return scrabbleSet.tileSetIsValid(userInput);
        }

        ///<summary>
        /// This arranges the words based on their lengths.
        /// </summary>
        public SortedList<int, List<String>> mapWordsByLength(IEnumerable<String> wordSet)
        {
            var lengthMap = new SortedList<int, List<String>>();

            foreach (String word in wordSet)
            {
                int wordLength = word.Length;

                List<String> WordsOfThisLength;
                if (lengthMap.ContainsKey(wordLength))
                    WordsOfThisLength = lengthMap[wordLength];
                else
                {
                    WordsOfThisLength = new List<string>(1);
                    lengthMap.Add(wordLength, WordsOfThisLength);
                }

                WordsOfThisLength.Add(word);
            }

            return lengthMap;
        }

    }
}
