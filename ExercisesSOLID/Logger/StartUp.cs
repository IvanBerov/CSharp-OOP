using Logger.Core.Factories;
using Loggerrr.Core;
using Loggerrr.Core.IO;

namespace Loggerrr
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAppenderFactory appenderFactory = new AppenderFactory();
            ILayoutFactory layoutFactory = new LayoutFactory();

            //IReader reader = new ConsloeReader();
            IReader reader = new FileReader();

            IEngine engine = new Engine(appenderFactory, layoutFactory, reader);

            engine.Run();
        }
    }
}
