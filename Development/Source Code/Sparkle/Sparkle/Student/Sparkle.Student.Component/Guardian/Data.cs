using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.Guardian
{

    public class Data : BinAff.Core.Data
    {

        public Conf.Profile.Data Profile { get; set; }

        public Conf.Relationship.Data Relationship { get; set; }

    }

}