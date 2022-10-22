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

            createHint();

        }    
            
        public void evaluateInput()        
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

        private void checkGuess()
        {
            letterMatchHH = 0; 
            //letterMatch = false;

            foreach (char i in letters)
            {
                //letterMatch = (guessLetter == i) ? true : false; 
                if (guessLetter == i)
                {
                    //letterMatch = true;
                    letterMatchHH++;
                }

            }

        }

        private void updateHint()
        {
            if (letterMatchHH > 0)
            {
                //int counter = 0;
                int indexHH = -1;
                foreach (char i in letters)
                {                           
                    indexHH++;                            
                    if (guessLetter == i)
                    {
                        hint[indexHH] = guessLetter;
                        //counter++;
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
