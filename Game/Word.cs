using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Word
    {
        private List<string> words = new List<string>
        {
            "abuse",
            "adult",
            "agent",
            "anger",
            "apple",
            "award",
            "basis",
            "beach",
            "birth",
            "block",
            "blood",
            "board",
            "brain",
            "bread",
            "break",
            "brown",
            "buyer",
            "cause",
            "chain",
            "chair",
            "chest",
            "chief",
            "child",
            "china",
            "claim",
            "class",
            "clock",
            "coach",
            "coast",
            "court",
            "cover",
            "cream",
            "crime",
            "cross",
            "crowd",
            "crown",
            "cycle",
            "dance",
            "death",
            "depth",
            "doubt",
            "draft",
            "drama",
            "dream",
            "dress",
            "drink",
            "drive",
            "earth",
            "enemy",
            "entry",
            "error",
            "event",
            "faith",
            "fault",
            "field",
            "fight",
            "final",
            "floor",
            "focus",
            "force",
            "frame",
            "frank",
            "front",
            "fruit",
            "glass",
            "grant",
            "grass",
            "green",
            "group",
            "guide",
            "heart",
            "henry",
            "horse",
            "hotel",
            "house",
            "image",
            "index",
            "input",
            "issue",
            "japan",
            "jones",
            "judge",
            "knife",
            "laura",
            "layer",
            "level",
            "lewis",
            "light",
            "limit",
            "lunch",
            "major",
            "march",
            "match",
            "metal",
            "model",
            "money",
            "month",
            "motor",
            "mouth",
            "music",
            "night",
            "noise",
            "north",
            "novel",
            "nurse",
            "offer",
            "order",
            "other",
            "owner",
            "panel",
            "paper",
            "party",
            "peace",
            "peter",
            "phase",
            "phone",
            "piece",
            "pilot",
            "pitch",
            "place",
            "plane",
            "plant",
            "plate",
            "point",
            "pound",
            "power",
            "press",
            "price",
            "pride",
            "prize",
            "proof",
            "queen",
            "radio",
            "range",
            "ratio",
            "reply",
            "right",
            "river",
            "round",
            "route",
            "rugby",
            "scale",
            "scene",
            "scope",
            "score",
            "sense",
            "shape",
            "share",
            "sheep",
            "sheet",
            "shift",
            "shirt",
            "shock",
            "sight",
            "simon",
            "skill",
            "sleep",
            "smile",
            "smith",
            "smoke",
            "sound",
            "south",
            "space",
            "speed",
            "spite",
            "sport",
            "squad",
            "staff",
            "stage",
            "start",
            "state",
            "steam",
            "steel",
            "stock",
            "stone",
            "store",
            "study",
            "stuff",
            "style",
            "sugar",
            "table",
            "taste",
            "terry",
            "theme",
            "thing",
            "title",
            "total",
            "touch",
            "tower",
            "track",
            "trade",
            "train",
            "trend",
            "trial",
            "trust",
            "truth",
            "uncle",
            "union",
            "unity",
            "value",
            "video",
            "visit",
            "voice",
            "waste",
            "watch",
            "water",
            "while",
            "white",
            "whole",
            "woman",
            "world",
            "youth"
        };
        private string word;
        private List<char> letters = new List<char> { };
        private char guessLetter;
        private TerminalService terminalService = new TerminalService();
        private List<char> hint = new List<char> { };
        public bool letterMatch; // added the false value

        public int letterMatchHH = 0; // created a new int

        public Word() { }

        public void pickWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            word = words[index];

            // printing to debugg
            System.Console.WriteLine(word);


            createHint();

        }    
            
        public void evaluateInput()        
        {            

            inputGuess();
            checkGuess();
            updateHint();
        }

        private void createHint()
        {
            foreach (char x in word)
            {
                letters.Add(x);
                hint.Add('_');
            }
        }

        private void checkGuess()
        {

            letterMatchHH = 0; 
            //letterMatch = false;

            foreach (char i in letters)
            {
                //letterMatch = (guessLetter == i) ? true : false; 

                if (guessLetter == i)
                {
                    //letterMatch = true;
                    letterMatchHH++;
                }


            }


        }

        private void updateHint()
        {
            if (letterMatchHH > 0)
            {
                //int counter = 0;
                int indexHH = -1;
                foreach (char i in letters)
                {
                    indexHH++;
                    if (guessLetter == i)
                    {

                        hint[indexHH] = guessLetter;
                        //counter++;

                    }
                }
            }
            terminalService.displaycharList(hint);
        }

        private void inputGuess()
        {
            guessLetter = terminalService.Readchar($"Guess a letter [a-z]: ");
            guessLetter = Char.ToLower(guessLetter);
        }
    }
}
