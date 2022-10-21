using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Word
    {
        private List<string> words = new List<string>
        {
            "abuse",
            "adult",
            "agent",
            "anger",
            "apple",
            "award",
        };
        private string word;
        private List<char> letters = new List<char> { };
        private char guessLetter;
        private TerminalService terminalService = new TerminalService();
        private List<char> hint = new List<char> { };
        public bool letterMatch;

        public Word() { }

        public void pickWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            word = words[index];
            createHint();
            inputGuess();
            checkGuess();
            updateHint();
        }

        private void createHint()
        {
            foreach (char x in word)
            {
                letters.Add(x);
                hint.Add('_');
            }
        }

        private void checkGuess()
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

        private void updateHint()
        {
            if (letterMatch = true)
            {
                int counter = 0;
                foreach (char i in letters)
                {
                    if (guessLetter == i)
                    {
                        hint[counter] = guessLetter;
                        counter++;
                    }
                }
            }
            terminalService.displaycharList(hint);
        }

        private void inputGuess()
        {
            guessLetter = terminalService.Readchar($"Guess a letter [a-z]: ");
            guessLetter = Char.ToLower(guessLetter);
        }
    }
}
