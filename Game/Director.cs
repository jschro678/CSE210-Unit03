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
            generateWord();
            while (isPlaying)
            {
                getInputs();                        // put getInputs out of the loop to above resetting the word every time    
                doUpdates();
                getRender();
            }
        }

        public void generateWord()
        {
            word.pickWord();
        }

        public void getInputs()
        {
            word.evaluateInput();
        }

        public void doUpdates()
        {
            jumper.updateJumper(word);
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

