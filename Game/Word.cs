using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Word
    {
        private List<string> words = new List<string>
        {
            "Abuse",
            "Adult",
            "Agent",
            "Anger",
            "Apple",
            "Award",
        };
        private string word;
        private List<char> letters = new List<char> { };
        private char guessLetter;
        private List<char> hint = new List<char> { };
        bool letterMatch;

        public Word()
        {
            pickWord();
            createHint();
        }

        private void pickWord()
        {
        Random random = new Random();
        int index = random.Next(wordDictionary.Count);
        String randomWord = wordDictionary[index];
        foreach (char x in randomWord)
        }

        private void createHint()
        {
        List<char> letters = new List<char>();
        public List<char> guess = new List<char>();
        }
            private guessLetter(){
        Console.WriteLine($"Guess a letter [a-z]: ")
    }

    private bool letterMatch = Word.updateHint();

    private pickWord(){

    }

    private createHint(){

    }
    }
}

