using System;
using System.Collections.Generic;

namespace ScrabbleWordFinder.Dictionary
{
    ///<summary>
    ///This class represents a node in the TrieDictionary. 
    ///Each node contains a character, a list of branches that lead to other words using the current prefix,
    ///a boolean flag that indicates whether the prefix at this node is a valid word and 
    ///the meaning of the word (if the word flag is true).
    ///</summary>
    public class TrieNode
    {

        public char Value { get; set; }             // The character value at this node

        public bool PrefixIsAWord { get; set; }    // True if the prefix at this node is a valid word

        public string Meaning { get; set; }         // The meaning of the word that ends at this node

        public List<TrieNode> Branches;            // The branches of this node.

        public TrieNode(char val)
        {
            this.Value = val;
            Branches = new List<TrieNode>();
        }

        public void AddBranch(TrieNode b)
        {
            Branches.Add(b);
        }

        ///<summary>
        /// Check if this node contains a branch with the character 'ch'.
        /// If found, return that branch. Else, return null.
        /// </summary>
        public TrieNode GetBranch(char ch)
        {
            ch = Char.ToUpper(ch);
            foreach (TrieNode n in Branches)
                if (n.Value == ch)
                    return n;

            return null;
        }

    }

}
