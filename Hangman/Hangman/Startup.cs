namespace Hangman
{
    using Hangman.Contracts;
    using Hangman.Engine;
    using Hangman.UI;
    using Ninject;
    using System.Reflection;

    public class Startup
    {
        static void Main()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IGameEngine engine = kernel.Get<IGameEngine>();

            IGameEngine game = engine;

            game.Run();
        }
    }
}
