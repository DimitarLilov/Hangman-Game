namespace Hangman.Contracts
{
    using System;

    /// <summary>
    /// Abstraction for reading input from the UI
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Method for reading the text input
        /// </summary>
        string ReadLine();

        /// <summary>
        /// Method for reading singel char
        /// </summary>
        char ReadKey();
    }
}
