using System;

namespace Sparkle.School.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String Name { get; set; }

        public Configuration.Facade.ContactInformation.Dto ContactInformation { get; set; }

        public String Logo { get; set; }

        public String AccreditationNumber { get; set; }

        public String Tan { get; set; }

        public Dto()
        {
            this.ContactInformation = new Configuration.Facade.ContactInformation.Dto();
        }

    }

}