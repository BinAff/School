using System.Threading.Tasks;

using AppCache = BinAff.Facade.Cache.Server;

namespace Sparkle.School.Facade
{

    public class Cache
    {

        public static void Start()
        {
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["StandardList"] = new Standard.Server(null).ReadAll<Standard.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["SectionList"] = new Section.Server(null).ReadAll<Section.Dto>();
            });
            Task.Factory.StartNew(() =>
            {
                AppCache.Current.Cache["ClassList"] = new Class.Server(null).ReadAll<Class.Dto>();
            });
        }

    }

}