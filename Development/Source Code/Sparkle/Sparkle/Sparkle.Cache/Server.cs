using AppCache = BinAff.Facade.Cache.Server;

using Conf = Sparkle.Configuration.Facade;
using Schl = Sparkle.School.Facade;

namespace Sparkle.Cache
{

    public class Server
    {

        public void Cache()
        {
            Conf.Cache.Start();

            AppCache.Current.Cache["StandardList"] = new Schl.Standard.Server(null).ReadAll<Schl.Standard.Dto>();
            AppCache.Current.Cache["SectionList"] = new Schl.Section.Server(null).ReadAll<Schl.Section.Dto>();
        }

    }

}