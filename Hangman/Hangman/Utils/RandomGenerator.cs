namespace Hangman.Utils
{
    using Hangman.Contracts;
    using System;

    public class RandomGenerator : IRandomGenerator
    {
        public int GenerateRandomNumber(int maxValue)
        {
            Random random = new Random();

            return random.Next(0, maxValue);
        }
    }
}
