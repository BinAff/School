namespace Sparkle.Cache
{

    public class Server
    {

        public static void Cache()
        {
            Configuration.Facade.Cache.Start();
            School.Facade.Cache.Start();
        }

    }

}