namespace Hangman.Utils
{
    using System.Reflection;
    using Hangman.Contracts;
    using Ninject;

    public class Game
    {
        private static Game instance;

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }

                return instance;
            }
        }

        public void Start()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IGameEngine engine = kernel.Get<IGameEngine>();

            engine.Run();
        }
    }
}
