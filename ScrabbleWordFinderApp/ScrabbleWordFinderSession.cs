using ScrabbleWordFinder.Dictionary;
using ScrabbleWordFinder.Filters;
using ScrabbleWordFinder;
using System;
using System.Collections.Generic;

namespace ScrabbleWordFinderApp
{
    public class ScrabbleWordFinderSession
    {
        DictionaryLoader DictLoader;
        TrieDictionary WordDictionary;
        IWordFinder wordFinder;
        WordFinderAdapter wordFinderAdapter;
        ScrabbleSet scrabbleSet;
        static ScrabbleWordFinderSession sessionInstance;

        private ScrabbleWordFinderSession()
        {

        }

        public static ScrabbleWordFinderSession getInstance()
        {
            if (null == sessionInstance)
                sessionInstance = new ScrabbleWordFinderSession();
            return sessionInstance;
        }

        public void Initialize()
        {
            WordDictionary = new TrieDictionary();
            DictLoader = new DictionaryLoader();
            DictLoader.loadDictionary(WordDictionary);
            wordFinder = new TrieFinder(WordDictionary);
            scrabbleSet = ScrabbleSet.getInstance();
            wordFinderAdapter = new WordFinderAdapter(wordFinder, scrabbleSet);
        }

        public string getMeaning(string word)
        {
            return WordDictionary.getMeaning(word);
        }

        public bool isCorrectWord(string word)
        {
            return WordDictionary.isCorrectWord(word);
        }

        public bool UserInputIsValid(string userInput)
        {
            return wordFinderAdapter.UserInputIsValid(userInput);
        }

        public List<string> findWords(string tiles, List<IWordFilter> filters)
        {
            return wordFinderAdapter.getCorrectWords(tiles, filters);
        }

        public List<string> findWords(string tiles)
        {
            return wordFinderAdapter.getCorrectWords(tiles);
        }

        public SortedList<int, List<String>> mapWordsByLength(IEnumerable<String> wordSet)
        {
            return wordFinderAdapter.mapWordsByLength(wordSet);
        }

        public int calculateScore(string word, string tiles)
        {
            return scrabbleSet.calculateScore(word, tiles);
        }

        public int calculateScoreWithoutConsiderations(string word)
        {
            return scrabbleSet.calculateScoreWithoutConsiderations(word);
        }
    }
}
