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
        public bool letterMatch;            // added the false value

        public int letterMatchHH = 0;            // created a new int

        public Word() { }

        public void pickWord()                              
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            word = words[index];

            // printing to debugg
            System.Console.WriteLine(word);

            createHint();                           // moved createHint() out of evaluate Input

        }    
            
        public void evaluateInput()                    // made a new method to avoid choosing a word over and over          
        {            
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

        private int checkGuess()
        {
            letterMatchHH = 0;          // setting letterMatchHH to 0
            letterMatch = false;

            foreach (char i in letters)
            {
                //letterMatch = (guessLetter == i) ? true : false;        // it is the same condition, just different syntax
                
                if (guessLetter == i)
                {
                    letterMatch = true;
                    letterMatchHH++;
                    //return;
                }
                
                
                
                
                // else //if (guessLetter != i)
                // {
                //     letterMatch = false;
                // }
            }

            return letterMatchHH;
            // if (letterMatch == true)
            // {
            //     letterMatchHH++;
            // }

        }

        private void updateHint()
        {
            //if (letterMatch == true)                // there was only one "=", it should be "=="
            if (letterMatchHH > 0)
            {
                int counter = 0;
                int indexHH = -1;
                foreach (char i in letters)
                {                           
                    indexHH++;                            
                    if (guessLetter == i)
                    {
                        hint[indexHH] = guessLetter;    // created a new indexHH, instead of counter
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
