namespace Hangman.Tests.Characters
{
    using Hangman.Characters;
    using Hangman.Contracts;
    using Hangman.Utils;
    using NUnit.Framework;

    [TestFixture]
    public class WordTests
    {
        [Test]
        public void CreateWordTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            string actual = word.SecretWord;
            string expected = "test";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaskedWordTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            string actual = word.MaskedWord;
            string expected = "t _ _ t ";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordContainsLetterTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            bool actual = word.ContainsLetter('e');
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordNotContainsLetterTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            bool actual = word.ContainsLetter('k');
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordNumberOfLetterReturnZeroTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            int actual = word.NumberOfLetter('k');
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordNumberOfLetterTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            int actual = word.NumberOfLetter('e');
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordRevealLetterTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            string actual = word.RevealLetter('e');
            string expected = "t e _ t ";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordNoRevealLetterTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            string actual = word.RevealLetter('k');
            string expected = "t _ _ t ";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordCheckIfWordIsRevealedTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            word.RevealLetter('e');

            word.RevealLetter('s');
            bool actual = word.CheckIfWordIsRevealed();
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WordCheckIfWordIsRevealedReturnFalseTest()
        {
            IRandomGenerator random = new RandomGenerator();
            string[] words = { "test" };
            IRandomWordGenerator randomWordGenerator = new RandomWordGenerator(random, words);
            Word word = new Word(randomWordGenerator);

            word.RevealLetter('e');

            bool actual = word.CheckIfWordIsRevealed();
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
