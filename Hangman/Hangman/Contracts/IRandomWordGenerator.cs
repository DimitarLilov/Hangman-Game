namespace Hangman.Contracts
{
    /// <summary>
    /// Abstraction for random word generator
    /// </summary>
    public interface IRandomWordGenerator
    {
        /// <summary>
        /// Method for generate random word
        /// </summary>
        string GenerateRandomWord();
    }
}
