using System;
using System.Collections.Generic;
using System.Text;
using ScrabbleWordFinder.Dictionary;

namespace ScrabbleWordFinder
{
    public class TrieFinder : IWordFinder
    {
        private TrieDictionary trieDictionary;

        public TrieFinder(TrieDictionary trieDictionary)
        {
            this.trieDictionary = trieDictionary;
        }

        public List<String> findWords(String inputTiles)
        {
            inputTiles = inputTiles.ToUpper();
            var validWords = new List<String>();

            // Search from the root node
            searchFromNode(trieDictionary.RootNode, string.Empty, inputTiles, ref validWords);

            return validWords;
        }

        /// <summary>
        /// Search the trie dictionary for correct words, starting from "currentNode".
        /// If any word is found, it is added to the reference list.
        /// </summary>
        private void searchFromNode(TrieNode currentNode, String currentPrefix, String inputTiles, ref List<String> validWords)
        {
            // ALGORITHM:
            // Check each branch of the current node. 
            // If the branch value is found in the input tiles, remove it from the tile set. 
            // Take that branch as the current node and search its branches recursively.
            // As we go down the trie, a prefix is compiled. 
            // If it is a valid word, we add it to the list.

            if (currentNode.PrefixIsAWord)
                validWords.Add(currentPrefix);

            foreach (TrieNode branch in currentNode.Branches)
            {
                StringBuilder mutableTileSet = new StringBuilder(inputTiles);
                char letterAtThisNode = branch.Value;

                int char_tile_index = inputTiles.IndexOf(letterAtThisNode);
                if (char_tile_index >= 0)
                {
                    mutableTileSet.Remove(char_tile_index, 1);
                    searchFromNode(branch, currentPrefix + letterAtThisNode, mutableTileSet.ToString(), ref validWords);
                }
                else
                {
                    // If the tile set does not contain the letter at this node,
                    // it may contain a BLANK which we can substitute for this letter.
                    int blank_tile_index = inputTiles.IndexOf(ScrabbleSet.BLANK);
                    if (blank_tile_index >= 0)
                    {
                        mutableTileSet.Remove(blank_tile_index, 1);
                        searchFromNode(branch, currentPrefix + letterAtThisNode, mutableTileSet.ToString(), ref validWords);
                    }
                }
            }

        }

    }
}
