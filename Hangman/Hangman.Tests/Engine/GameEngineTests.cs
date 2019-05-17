namespace Hangman.Tests.Engine
{
    using Hangman.Contracts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class GameEngineTests
    {
        [Test]
        public void GameEngineRunTest()
        {
            var fakeIGameEngine = new Mock<IGameEngine>();
            fakeIGameEngine.Setup(e => e.Run());
            fakeIGameEngine.Object.Run();
            fakeIGameEngine.Verify(u => u.Run());
        }
    }
}
