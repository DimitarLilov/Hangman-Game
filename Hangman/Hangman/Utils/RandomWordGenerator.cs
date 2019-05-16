namespace Hangman.Utils
{
    using Hangman.Contracts;

    public class RandomWordGenerator : IRandomWordGenerator
    {
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
        }

        public RandomWordGenerator(IRandomGenerator random, string[] words)
        {
            this.random = random;
            this.words = words;
        }

        public string GenerateRandomWord()
        {
            return this.words[random.GenerateRandomNumber(this.words.Length - 1)];
        }
    }
}
