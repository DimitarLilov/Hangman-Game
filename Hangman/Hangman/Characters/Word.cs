namespace Hangman.Characters
{
    using System.Linq;
    using System.Text;
    using Hangman.Contracts;

    public class Word : IWord
    {
        private readonly string word;

        private string maskedWord;

        public Word(IRandomWordGenerator randomWordGenerator)
        {
            this.word = randomWordGenerator.GenerateRandomWord();
            this.maskedWord = this.Mask(this.word);
        }

        public string MaskedWord => this.maskedWord;

        public bool ContainsLetter(char letter)
        {
            letter = char.ToLower(letter);

            return this.word.Contains(letter);
        }

        public int NumberOfLetter(char letter)
        {
            int number = 0;
            letter = char.ToLower(letter);

            for (int index = 1; index < this.word.Length - 1; index++)
            {
                if (this.word[index].Equals(letter))
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

            for (int wordLenght = 0; wordLenght < this.word.Length - 1; wordLenght++)
            {
                int letterIndex = this.word.IndexOf(letterLowerCase, wordLenght);

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
