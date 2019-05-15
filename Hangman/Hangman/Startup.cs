namespace Hangman
{
    using System.Reflection;
    using Hangman.Contracts;
    using Ninject;

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
