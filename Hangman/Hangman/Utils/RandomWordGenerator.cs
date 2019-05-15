namespace Hangman.Utils
{
    using System;
    using Hangman.Contracts;

    public class RandomWordGenerator : IRandomWordGenerator
    {
        private string word;

        private readonly string[] words =
        {
            "unit",
            "nail",
            "button",
            "scrawny",
            "true",
            "mean",
            "onerous",
            "seal",
            "friendly",
            "guarded",
            "sable",
            "scissors"
        };

        private readonly IRandomGenerator random;

        public RandomWordGenerator(IRandomGenerator random)
        {
            this.random = random;
            this.Word = this.word;
        }

        public string Word
        {
            get
            {
                return this.word;
            }

            private set
            {
                this.word = this.GetRandomWord();
            }
        }

        private string GetRandomWord()
        {
            return this.words[random.GenerateRandomNumber(this.words.Length - 1)];
        }
    }
}
