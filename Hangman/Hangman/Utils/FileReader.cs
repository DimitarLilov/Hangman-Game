namespace Hangman.Utils
{
    using System.IO;
    using Hangman.Contracts;

    public class FileReader : IFileReader
    {
        public string[] ReaderAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public string ReaderAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
