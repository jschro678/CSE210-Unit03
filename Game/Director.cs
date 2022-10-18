using System;

namespace Unit03.Game
{
    public class Director
    {
        bool isPlaying = true;
        TerminalService terminalService = new TerminalService();

        public Director()
        {
            current_card = myCard.pick_card();
            totalScore = 100;
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
            Console.WriteLine($"This card is: {current_card}");
            Console.Write("Higher or Lower? [h/l] ");
            guess_card = Console.ReadLine();
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
