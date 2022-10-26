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
        public bool isPlaying = true;
        TerminalService terminalService = new TerminalService();

        public Jumper() { }

        public void updateJumper(Word word)
        {
            //letterMatch = word.letterMatch;
            letterMatchHH = word.letterMatchHH;
            
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
                }
            }

            terminalService.displayString(drawing);
        }
    }
}
