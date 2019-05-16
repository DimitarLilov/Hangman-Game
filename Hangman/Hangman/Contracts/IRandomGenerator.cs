namespace Hangman.Contracts
{
    /// <summary>
    /// Abstraction for random generator
    /// </summary>
    public interface IRandomGenerator
    {
        /// <summary>
        /// Method for generate random number
        /// </summary>
        /// <param name="maxValue">Maximum value</param>
        int GenerateRandomNumber(int maxValue);
    }
}
