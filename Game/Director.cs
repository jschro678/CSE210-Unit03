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
            word.inputGuess();
        }

        public void doUpdates()
        {
            jumper.updateJumper();
        }

        public void getRender()
        {
            if (!isPlaying)
            {
                return;
            }
        }
    }
}
