using System;

namespace Unit2.CardGame
{
    /// <summary>
    /// A Card with the its value attribute will be generated.
    /// </summary>

    public class Card
    {
        public int _value;

        public Card()
        {

        }

        /// <summary>
        /// Generates a new random value when the Draw function is called.
        /// Value will be between 1-13.
        /// </summary>
        public void Draw()
        {
            Random number = new Random();
            _value = number.Next(1,14);
        }
    }
}