using Conf = Sparkle.Configuration.Facade;

namespace Sparkle.Student.Facade.PersonalInformation.Guardian
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Conf.Profile.Dto Profile { get; set; }

        public Conf.Relationship.Dto Relationship { get; set; }

        public Dto()
        {
            this.Profile = new Conf.Profile.Dto();
            this.Relationship = new Conf.Relationship.Dto();
        }

    }

}