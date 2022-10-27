using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {
        public List<string> drawing = new List<string>
        {
            @" ___",
            @"/___\",
            @"\   /",
            @" \ /",
            @"  0",
            @" /|\",
            @" / \",
            "       ",
            "^^^^^^"
        };
        private int lives = 5;
        //Word word = new Word();
        private List<string> deadDrawing = new List<string>
        {
            @"  X",
            @" /|\",
            @" / \",
            @"^^^^^^",
        };

        private bool letterMatch;
        
        private int letterMatchHH;          // created this new variable

        public List<char> hint = new List<char> { };
        public bool isPlaying = true;
        TerminalService terminalService = new TerminalService();

        public Jumper() { }

        public void updateJumper(Word wordInstance)
        {
            //letterMatch = word.letterMatch;
            letterMatchHH = wordInstance.letterMatchHH;
            hint = wordInstance.hint;
            if(letterMatchHH == 0)
            {
                lives = lives - 1;
                if (lives > 0)
                {
                    drawing.RemoveAt(0);
                }
                else
                {
                    drawing = deadDrawing;
                    isPlaying = false;
                    terminalService.displayString(drawing);
                    return;
                }
            }
    
            terminalService.displayString(drawing);


            int counter = 0;
            foreach (char i in hint)
            {

                if ('_' == i)
                {
                    isPlaying = true;
                    
                }
                else
                {
                    counter++;
                }  
            }

            if (counter == 5)
            {
                isPlaying = false;
            }

        }
    }
}
