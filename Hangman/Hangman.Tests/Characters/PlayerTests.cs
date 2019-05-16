namespace Hangman.Tests.Characters
{
    using Hangman.Characters;
    using NUnit.Framework;

    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void CreatePlayerTest()
        {
            Player player = new Player();
            int actual = player.Lives;
            int expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerLivesTest()
        {
            Player player = new Player();
            player.Lives--;
            int actual = player.Lives;
            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

    }
}
