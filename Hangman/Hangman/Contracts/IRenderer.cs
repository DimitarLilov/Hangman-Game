namespace Hangman.Contracts
{
    public interface IRenderer
    {
        /// <summary>
        /// Method for writing the text output.
        /// </summary>
        void Write(string message, params object[] param);

        /// <summary>
        /// Method for writing line the text output.
        /// </summary>
        void WriteLine(string message, params object[] param);

        /// <summary>
        /// Method for writing in position the text output.
        /// </summary>
        void WritePosition(int x, int y, string message, params object[] param);

        /// <summary>
        /// Method for clear the text output.
        /// </summary>
        void Clear();
    }
}
