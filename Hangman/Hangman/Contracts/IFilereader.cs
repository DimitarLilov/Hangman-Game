namespace Hangman.Contracts
{
    /// <summary>
    /// Abstraction for File Reader
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Method for reading the all text file
        /// </summary>
        string ReaderAllText(string path);

        /// <summary>
        /// Method for reading the text line
        /// </summary>
        string[] ReaderAllLines(string path);
    }
}