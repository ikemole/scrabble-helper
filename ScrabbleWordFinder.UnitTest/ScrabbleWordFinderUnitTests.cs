using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleWordFinder.Filters;
using ScrabbleWordFinder.Dictionary;
using System.IO;

namespace ScrabbleWordFinder.UnitTest
{
    [TestClass]
    public class ScrabbleWordFinderUnitTests
    {
        static DictionaryLoader DictLoader;
        static TrieDictionary WordDictionary;
        static IWordFinder wordFinder;
        static WordFinderAdapter wordFinderAdapter;
        static ScrabbleSet scrabbleSet;

        [ClassInitialize]
        public static void InitializeTestObjects(TestContext testContext)
        {
            WordDictionary = new TrieDictionary();
            DictLoader = new DictionaryLoader();
            DictLoader.loadDictionary(WordDictionary);
            wordFinder = new TrieFinder(WordDictionary);
            scrabbleSet = ScrabbleSet.getInstance();
            wordFinderAdapter = new WordFinderAdapter(wordFinder, scrabbleSet);
        }

        [TestMethod]
        public void CheckIfDictionaryFileCanBeRead()
        {
            StreamReader reader = DictLoader.loadDictionaryTextStreamFromAssembly();
            Assert.IsNotNull(reader);
        }

        [TestMethod]
        public void FindMeaningInDictionary()
        {
            string testMeaning = WordDictionary.getMeaning("Test");
            Assert.IsTrue(testMeaning.Contains("to subject to an examination"));
        }

        [TestMethod]
        public void FindMeaningInDictionaryNotFound()
        {
            string testMeaning = WordDictionary.getMeaning("qwasgd");
            Assert.IsNull(testMeaning);
        }

        [TestMethod]
        public void CheckIfWordIsValid()
        {
            Assert.IsTrue(WordDictionary.isCorrectWord("test"));
            Assert.IsFalse(WordDictionary.isCorrectWord("lkadubqw"));
        }

        [TestMethod]
        public void TestTileSetIsValid()
        {
            string tileSet = "TESTQ";
            bool validTileSet = scrabbleSet.tileSetIsValid(tileSet);
            Assert.IsTrue(validTileSet);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestTileSetIsNotValid()
        {
            string tileSet = "TESTQQ";
            bool validTileSet = scrabbleSet.tileSetIsValid(tileSet);
        }

        [TestMethod]
        public void TestFindWordsUsingTiles()
        {
            List<string> wordsThatCanBeFormed = wordFinderAdapter.getCorrectWords("TEST");
            CollectionAssert.Contains(wordsThatCanBeFormed, "SET");
        }

        [TestMethod]
        public void TestStartsWithFilter()
        {
            var words = new List<string> { "test", "set", "best", "and" };
            var startsWithFilter = new StartsWithFilter("S");
            var matchingWords = startsWithFilter.ApplyRule(words);

            var expectedList = new List<string> { "set" };
            CollectionAssert.AreEquivalent(expectedList, matchingWords);
        }

        [TestMethod]
        public void TestWordFilters()
        {
            string tiles = "TEST";
            var wordFilters = new List<IWordFilter>{ 
                new EndsWithFilter("T"),
                new StartsWithFilter("S"),
                new LengthFilter(3),
                new ScoreFilter(3, tiles),
                new ContainsFilter("T,E")
            };

            List<string> wordsThatCanBeFormed = wordFinderAdapter.getCorrectWords("TEST", wordFilters);
            CollectionAssert.Contains(wordsThatCanBeFormed, "SET");
        }

        [TestMethod]
        public void TestMapWordsByLength()
        {
            List<string> listOfWords = new List<string> { "TEST", "ES", "ET", "SET", "SETT", "TET", "TETS", "STET" };
            var MapWordsByLength = wordFinderAdapter.mapWordsByLength(listOfWords);
            Assert.IsTrue(MapWordsByLength.ContainsKey(3));
            CollectionAssert.AreEquivalent(MapWordsByLength[3], new List<string> { "SET", "TET" });
        }

    }
}
