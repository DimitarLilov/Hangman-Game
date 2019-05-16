namespace Hangman.Contracts
{
    /// <summary>
    /// Abstraction for player character
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        ///   Property for gets and sets player lives  
        /// </summary>
        int Lives { get; set; }
    }
}
