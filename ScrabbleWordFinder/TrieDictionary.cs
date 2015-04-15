using System;
using System.Collections.Generic;

namespace ScrabbleWordFinder.Dictionary
{
    /// <summary>
    /// This class represents a dictionary implemented as a trie structure.
    /// </summary>
    public class TrieDictionary : IWordDictionary
    {
        public readonly TrieNode RootNode;

        public TrieDictionary()
        {
            RootNode = new TrieNode('\0');
        }

        public void addWordAndMeaning(String word, String meaning)
        {
            TrieNode currentNode = RootNode;

            char[] letters = word.ToCharArray();
            foreach (char ch in letters)
            {
                TrieNode charNode = currentNode.GetBranch(ch);
                if (charNode == null)
                {
                    charNode = new TrieNode(ch);
                    currentNode.AddBranch(charNode);
                }
                currentNode = charNode;
            }

            // Mark the last node of this word as a word-end.
            // Set its meaning on the node
            currentNode.PrefixIsAWord = true;
            currentNode.Meaning = meaning;
        }

        private void findWordsFromNode(TrieNode node, String prefix, ref List<String> foundWords)
        {
            if (node.PrefixIsAWord)
                foundWords.Add(prefix);

            foreach (TrieNode n in node.Branches)
            {
                String newPrefix = prefix + n.Value;
                findWordsFromNode(n, newPrefix, ref foundWords);
            }

        }

        /// <summary>
        /// Get all words that start with a prefix.
        /// </summary>
        public List<String> getWordsWithPrefix(String prefix)
        {
            prefix = prefix.ToUpper();

            TrieNode lastNode = navigateToLastNode(prefix);
            if (lastNode == null)
                return null;
            else
            {
                // find words starting from the last node
                List<String> foundWords = new List<String>();
                findWordsFromNode(lastNode, prefix, ref foundWords);
                return foundWords;
            }
        }

        /// <summary>
        /// Navigate to the last node of the word or prefix.
        /// </summary>
        private TrieNode navigateToLastNode(String prefix)
        {
            TrieNode currentNode = RootNode;
            char[] letters = prefix.ToCharArray();
            foreach (char ch in letters)
            {
                TrieNode charNode = currentNode.GetBranch(ch);
                if (charNode == null)
                    return null;

                currentNode = charNode;
            }

            return currentNode;
        }

        public String getMeaning(String word)
        {
            TrieNode endNode = navigateToLastNode(word);
            if (endNode == null)
                return null;

            return endNode.Meaning;
        }

        public bool isCorrectWord(String word)
        {
            TrieNode endNode = navigateToLastNode(word);
            if (endNode == null)
                return false;

            return endNode.PrefixIsAWord;
        }

    }
}
