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
        /// Method for reading keypress info
        /// </summary>
        ConsoleKeyInfo ReadKey();
    }
}
