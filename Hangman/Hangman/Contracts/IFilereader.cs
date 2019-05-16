namespace Hangman.Contracts
{
    public interface IFileReader
    {
        string ReaderAllText(string path);

        string[] ReaderAllLines(string path);
    }
}
