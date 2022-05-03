using System;
using System.Collections.Generic;
using System.Text;

namespace SoloProjectSimonSays
{
    class SimonGame
    {
        public bool GameOver { get; private set; } = false;

        public List<Colors> Colors { get; private set; }

        private int GuessPosition = 0;

        public SimonGame()
        {
            Colors = new List<Colors>();
            GenerateColor();
        }

        public bool MakeGuess(Colors Color)
        {
            if (Colors[GuessPosition] != Color)
            {
                GameOver = true;
                return false;
            }
            else
            {
                //Round over
                if (GuessPosition == Colors.Count - 1)
                {
                    GuessPosition = 0;
                    GenerateColor();
                    return false;
                }
                GuessPosition++;
                return true;
            }
        }

        private void GenerateColor()
        {
            Random ran = new Random();
            int RanColorAsInt = ran.Next(4);
            Colors RanColor = (Colors)RanColorAsInt;

            Colors.Add(RanColor);
        }
    }
}
