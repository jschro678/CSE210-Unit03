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
        private TerminalService terminalService = new TerminalService();
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
            int index = random.Next(words.Count);
            word = words[index];
        }

        private void createHint()
        {
            foreach (char x in word)
            {
                letters.Add(x);
                hint.Add('_');
            }
        }

        private void updateHint()
        {
            foreach (char i in letters)
            {
                if (guessLetter == i)
                {
                    letterMatch = true;
                    return;
                }
                else if (guessLetter != i)
                {
                    letterMatch = false;
                }
            }
        }

        public void inputGuess()
        {
            guessLetter = terminalService.Readchar($"Guess a letter [a-z]: ");
            updateHint();
        }

        public void displayword()
        {
            terminalService.WriteText(word);
        }
    }
}
