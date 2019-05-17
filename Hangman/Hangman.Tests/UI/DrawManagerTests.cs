namespace Hangman.Tests.UI
{
    using System;
    using Hangman.Contracts;
    using Hangman.UI;
    using Hangman.Utils;
    using NUnit.Framework;

    [TestFixture]
    public class DrawManagerTests
    {
        [Test]
        public void DrawLostMessageCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawLostMessage("test");

            var expected = GlobalConstants.Lost + Environment.NewLine + GlobalConstants.SecretWord + "test" + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawWinMessageCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawWinMessage();

            var expected = GlobalConstants.Win + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawEnterLetterMessageCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawEnterLetterMessage();

            var expected = GlobalConstants.EnterLetter;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawNewLineCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawNewLine();

            var expected = Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawUnrevealedLetterCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawUnrevealedLetter('t');

            var expected = GlobalConstants.UnrevealedLetter + "'t'" + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawRevealedLetterOneLetterCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawRevealedLetter(1);

            var expected = GlobalConstants.RevealedLetter + "1 letter" + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawRevealedLetterTwoLetterCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawRevealedLetter(2);

            var expected = GlobalConstants.RevealedLetter + "2 letters" + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void DrawMaskedWordCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.DrawMaskedWord("test");

            var expected = "test" + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void IncorrectLetterCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.IncorrectLetter();

            var expected = GlobalConstants.IncorrectLetter + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }

        [Test]
        public void PlayAgainCorrectMessageTest()
        {
            IFileReader fileReader = new FileReader();
            IRenderer render = new ConsoleRender();
            IDrawable drawManager = new DrawManager(fileReader, render);

            var consoleOutput = new ConsoleOutput();
            drawManager.PlayAgain();

            var expected = GlobalConstants.PlayAgain + Environment.NewLine;

            Assert.AreEqual(expected, consoleOutput.GetOuput());
        }
    }
}
