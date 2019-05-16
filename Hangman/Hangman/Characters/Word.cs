namespace Hangman.Characters
{
    using System.Linq;
    using System.Text;
    using Hangman.Contracts;

    public class Word : IWord
    {
        private readonly string secretWord;

        private string maskedWord;

        public Word(IRandomWordGenerator randomWordGenerator)
        {
            this.secretWord = randomWordGenerator.GenerateRandomWord();
            this.maskedWord = this.Mask(this.secretWord);
        }

        public string MaskedWord => this.maskedWord;

        public string SecretWord => this.secretWord;

        public bool ContainsLetter(char letter)
        {
            letter = char.ToLower(letter);

            return this.secretWord.Contains(letter);
        }

        public int NumberOfLetter(char letter)
        {
            int number = 0;
            letter = char.ToLower(letter);

            for (int index = 1; index < this.secretWord.Length - 1; index++)
            {
                if (this.secretWord[index].Equals(letter))
                {
                    number++;
                }
            }

            return number;
        }

        public string RevealLetter(char letter)
        {
            StringBuilder maskedWordBuilder = new StringBuilder(this.maskedWord);
            char letterLowerCase = char.ToLower(letter);

            for (int wordLenght = 0; wordLenght < this.secretWord.Length - 1; wordLenght++)
            {
                int letterIndex = this.secretWord.IndexOf(letterLowerCase, wordLenght);

                if (letterIndex >= 0)
                {
                    maskedWordBuilder[letterIndex * 2] = letter;
                }
            }

            this.maskedWord = maskedWordBuilder.ToString();

            return this.maskedWord;
        }

        public bool CheckIfWordIsRevealed()
        {
            return this.maskedWord.All(ch => ch != '_');
        }

        private string Mask(string word)
        {
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];

            StringBuilder masked = new StringBuilder(word.Length * 2);
            masked.Append($"{firstLetter} ");
            for (int i = 0; i < word.Length - 2; i++)
            {
                masked.Append($"_ ");
            }

            masked.Append($"{lastLetter} ");

            return masked.ToString();
        }
    }
}
