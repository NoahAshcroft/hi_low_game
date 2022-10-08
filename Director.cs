using System;
using System.Collections.Generic;

namespace Unit2.CardGame
{
    /// <summary>

    /// </summary>
    public class Director
    {
        Card currentCard = new Card();
        Card nextCard = new Card();
        int _score = 0;
        int _totalScore = 300;
        bool _isPlaying = true;
        string _guess = "";
        string _isPlay = "";

        /// <summary>
        
        /// </summary>
        public Director()
        {

        }

        /// <summary>

        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Draw a card from the pile and display to the player.
        /// The player will guess if the next card for higher or lower value.
        /// </summary>
        public void GetInputs()
        {
            currentCard.Draw();
            Console.WriteLine($"The card is: {currentCard._value}");
            Console.Write("Higher or lower? (h/l) ");
            _guess = Console.ReadLine();
        }

        /// <summary>
        /// Draw the next card and display the card value.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }
            nextCard.Draw();
            Console.WriteLine($"Next card is: {nextCard._value}");
        }

        /// <summary>

        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            if (_guess == "h")
            {
                if (nextCard._value > currentCard._value)
                {
                    _score = 100;
                }
                else if (currentCard._value > nextCard._value)
                {
                    _score = -75;
                }
            }
            else if (_guess == "l")
            {
                if (nextCard._value < currentCard._value)
                {
                    _score = 100;
                }
                else if (currentCard._value < nextCard._value)
                {
                    _score = -75;
                }
            }

            _totalScore += _score;

            Console.WriteLine($"Your total score is: {_totalScore}");
            
            if (_isPlaying = (_totalScore > 0))
            {
                Console.Write($"Play again? (y/n) ");
                _isPlay = Console.ReadLine();
                _isPlaying = (_isPlay == "y");
            }
            else
            {
                _isPlaying = false;
            }
        }
    }
}