using System;
using ScrabbleWordFinder.Dictionary;

namespace ScrabbleWordFinder.Filters
{
    public class ScoreFilter : AbstractWordFilter
    {
        private int minimumScore;
        private String tiles;

        public ScoreFilter(int minimumScore, String tiles)
        {
            this.minimumScore = minimumScore;
            this.tiles = tiles.ToUpper();
        }

        public override bool isValid(String word)
        {
            word = word.ToUpper();

            ScrabbleSet scrabbleSet = ScrabbleSet.getInstance();
            int score = scrabbleSet.calculateScore(word, tiles);
            return ( score >= minimumScore );
        }

    }
}
