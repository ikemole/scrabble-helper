using System;
using System.Collections.Generic;
using System.Text;

namespace ScrabbleWordFinder
{
    public struct TileValues
    {
        public readonly int Points;
        public readonly int Count;

        public TileValues(int Points, int Count)
        {
            this.Count = Count;
            this.Points = Points;
        }
    }

    public class ScrabbleSet
    {
        public static char BLANK = '_';
        private Dictionary<char, TileValues> TileSet;
        private static ScrabbleSet scrabbleSetInstance;

        private ScrabbleSet()
        {
            createTileSet();
        }

        public static ScrabbleSet getInstance()
        {
            if (null == scrabbleSetInstance)
                scrabbleSetInstance = new ScrabbleSet();

            return scrabbleSetInstance;
        }

        private void createTileSet()
        {
            TileSet = new Dictionary<char, TileValues>
            {
                {'A',	new TileValues( Points : 1,		Count : 10 )},
                {'B',	new TileValues( Points : 3,		Count : 2 )},
                {'C',	new TileValues( Points : 3,		Count : 2 )},
                {'D',	new TileValues( Points : 2,		Count : 4 )},
                {'E',	new TileValues( Points : 1,		Count : 12 )},
                {'F',	new TileValues( Points : 4,		Count : 2 )},
                {'G',	new TileValues( Points : 2,		Count : 3 )},
                {'H',	new TileValues( Points : 4,		Count : 2 )},
                {'I',	new TileValues( Points : 1,		Count : 9 )},
                {'J',	new TileValues( Points : 8,		Count : 1 )},
                {'K',	new TileValues( Points : 5,		Count : 1 )},
                {'L',	new TileValues( Points : 1,		Count : 4 )},
                {'M',	new TileValues( Points : 3,		Count : 2 )},
                {'N',	new TileValues( Points : 1,		Count : 6 )},
                {'O',	new TileValues( Points : 1,		Count : 8 )},
                {'P',	new TileValues( Points : 3,		Count : 2 )},
                {'Q',	new TileValues( Points : 10,	Count : 1 )},
                {'R',	new TileValues( Points : 1,		Count : 6 )},
                {'S',	new TileValues( Points : 1,		Count : 4 )},
                {'T',	new TileValues( Points : 1,		Count : 6 )},
                {'U',	new TileValues( Points : 1,		Count : 4 )},
                {'V',	new TileValues( Points : 4,		Count : 2 )},
                {'W',	new TileValues( Points : 4,		Count : 2 )},
                {'X',	new TileValues( Points : 8,		Count : 1 )},
                {'Y',	new TileValues( Points : 4,		Count : 2 )},
                {'Z',	new TileValues( Points : 10,	Count : 1 )},
                {BLANK,	new TileValues( Points : 0,		Count : 2 )}
            };
        }

        public int getTilePoints(char ch)
        {
            ch = Char.ToUpper(ch);
            if (TileSet.ContainsKey(ch))
                return TileSet[ch].Points;
            else
                throw new ApplicationException("The tile \"" + ch + "\" was not found");
        }

        public int getTileCount(char ch)
        {
            ch = Char.ToUpper(ch);
            if (TileSet.ContainsKey(ch))
                return TileSet[ch].Count;
            else
                throw new ApplicationException("The tile \"" + ch + "\" was not found");
        }

        /// <summary>
        /// This calculates the total plain score for a word.
        /// It does not verify if some letters were written with a BLANK.
        /// </summary>
        public int calculateScoreWithoutConsiderations(String word)
        {
            word = word.Trim();
            int score = 0;
            foreach (char ch in word.ToCharArray())
                score += getTilePoints(ch);
            return score;
        }

        /// <summary>
        /// This calculates the total plain score for a word.
        /// It takes into consideration that some of the letters 
        /// may be written with a BLANK tile. 
        /// Therefore, calculated score is more accurate.
        /// </summary>
        public int calculateScore(String word, String tiles)
        {
            if (!tileSetIsValid(tiles))
                throw new ApplicationException("The tile set is not valid.");

            int total = 0;
            tiles = tiles.ToUpper();
            word = word.ToUpper().Trim();
            StringBuilder mutableTiles = new StringBuilder(tiles.ToUpper());
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                int charTilePos = mutableTiles.ToString().IndexOf(ch);
                if (charTilePos >= 0)
                {
                    total += getTilePoints(ch);
                    mutableTiles.Remove(charTilePos, 1);
                }
                else
                {
                    int blankTilePos = mutableTiles.ToString().IndexOf(BLANK);
                    if (blankTilePos >= 0)
                    {
                        mutableTiles.Remove(blankTilePos, 1);
                        //Add 0 for blank tile
                    }
                    else
                        throw new ApplicationException("Score cannot be calculated because the word cannot be formed using the given tiles.");
                }
            }

            return total;
        }


        public bool tileSetIsValid(String tiles)
        {
            var charMap = new Dictionary<char, int>(1);

            //Create character-count map for input tiles
            foreach (char ch in tiles.ToUpper().ToCharArray())
            {
                if (charMap.ContainsKey(ch))
                    charMap[ch] = charMap[ch] + 1;
                else
                    charMap.Add(ch, 1);
            }

            // Check if each character count is less than 
            // or equal to the allowed number
            foreach (char ch in charMap.Keys)
            {
                if (charMap[ch] > getTileCount(ch))
                    throw new ApplicationException("Your tile set contains " + charMap[ch] + " " + ( ch == BLANK ? "BLANK" : ch.ToString() ) + " tiles. " +
                "The game has only " + getTileCount(ch) + " available.");
            }

            return true;
        }

    }
}
