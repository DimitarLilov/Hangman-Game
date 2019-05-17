namespace Hangman.Tests.UI
{
    using Hangman.Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ConsoleReaderTests
    {
        [Test]
        public void ConsoleReadKeyMethodIsCalled()
        {
            var fakerReader = new Mock<IReader>();
            fakerReader.Setup(r => r.ReadKey());
            fakerReader.Object.ReadKey();
            fakerReader.Verify(r => r.ReadKey(), Times.AtLeast(1));
        }

        [Test]
        public void ConsoleReadLineMethodIsCalled()
        {
            var fakerReader = new Mock<IReader>();
            fakerReader.Setup(r => r.ReadLine());
            fakerReader.Object.ReadLine();
            fakerReader.Verify(r => r.ReadLine(), Times.AtLeast(1));
        }
    }
}
