using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Word
    {
        private List<string> words = new List<string>
        {
            "Abuse",
            "Adult",
            "Agent",
            "Anger",
            "Apple",
            "Award",
        };
        private string word;
        private List<char> letters = new List<char> { };
        private char guessLetter;
        private List<char> hint = new List<char> { };
        bool letterMatch;

        public Word()
        {
            pickWord();
            createHint();
        }

        private void pickWord()
        {
            Random random = new Random();
            word = words[random.Next(0, 5)];
        }

        private void createHint() { }
    }
}
