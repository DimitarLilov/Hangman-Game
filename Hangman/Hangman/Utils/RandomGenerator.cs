namespace Hangman.Utils
{
    using System;
    using Hangman.Contracts;

    public class RandomGenerator : IRandomGenerator
    {
        public int GenerateRandomNumber(int maxValue)
        {
            Random random = new Random();

            return random.Next(0, maxValue);
        }
    }
}
