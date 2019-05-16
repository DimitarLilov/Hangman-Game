namespace Hangman.Contracts
{
    public interface IWord
    {
        string SecretWord { get; }

        string MaskedWord { get; }

        bool ContainsLetter(char letter);

        int NumberOfLetter(char letter);

        string RevealLetter(char letter);

        bool CheckIfWordIsRevealed();
    }
}
