using System;

namespace Unit03.Game
{
    public class Director
    {
        private bool isPlaying = true;
        TerminalService terminalService = new TerminalService();
        Jumper jumper = new Jumper();
        Word word = new Word();

        public Director()
        {
            // current_card = myCard.pick_card();
            // totalScore = 100;
        }

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
            jumper.updateJumper();
        }

        public void doUpdates() { }

        public void getRender()
        {
            if (!isPlaying)
            {
                return;
            }
        }
    }
}
