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
        private List<string> deadDrawing = new List<string>
        {
            @"^^^^^^",
            @"  X",
            @" /|\",
            @" / \",
        };
        Word word = new Word();

        private bool letterMatch = word.updateHint();

        private Jumper() { }

        private void updateJumper()
        {
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
                }
            }
            else if (letterMatch)
            {
                return;
            }
        }
    }
}