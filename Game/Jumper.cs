using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {
        public List<string> drawing = new List<string>
        {
            @" ---",
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
        Word word = new Word();
        private List<string> deadDrawing = new List<string>
        {
            @"^^^^^^",
            @"  X",
            @" /|\",
            @" / \",
        };

        private bool letterMatch;
        public bool isPlaying;
        TerminalService terminalService = new TerminalService();

        public Jumper() { }

        public void updateJumper()
        {
            letterMatch = word.letterMatch;
            if (!letterMatch)
            {
                lives = lives - 1;
                if (lives != 0)
                {
                    drawing.RemoveAt(0);
                }
                else
                {
                    drawing = deadDrawing;
                    isPlaying = false;
                }
            }
            else if (letterMatch)
            {
                return;
            }

            terminalService.displayString(drawing);
        }
    }
}
