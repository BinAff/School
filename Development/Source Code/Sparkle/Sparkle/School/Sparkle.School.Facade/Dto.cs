using System;

namespace Sparkle.School.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String Name { get; set; }

        public Configuration.Facade.ContactInformation.Dto ContactInformation { get; set; }

        public Dto()
        {
            this.ContactInformation = new Configuration.Facade.ContactInformation.Dto();
        }

    }

}