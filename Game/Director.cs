using System;

namespace Unit03.Game
{
    public class Director
    {
        private bool isPlaying = true;
        TerminalService terminalService = new TerminalService();
        Jumper jumper = new Jumper();
        Word word = new Word();

        public Director() { }

        public void StartGame()
        {
            while (isPlaying)
            {
                getInputs();
                doUpdates();
                getRender();
            }
        }

        public void getInputs()
        {
            word.pickWord();
        }

        public void doUpdates()
        {
            jumper.updateJumper();
        }

        public void getRender()
        {
            isPlaying = jumper.isPlaying;
            if (!isPlaying)
            {
                return;
            }
        }
    }
}

