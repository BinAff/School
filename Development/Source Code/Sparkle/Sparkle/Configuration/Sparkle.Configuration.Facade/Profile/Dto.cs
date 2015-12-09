using System;

namespace Sparkle.Configuration.Facade.Profile
{

    public class Dto : Sparkle.Core.Facade.Dto
    {
        
        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Occupation.Dto Occupation { get; set; }

        public ContactInformation.Dto ContactInformation { get; set; }

        public Mobile.Dto Mobile { get; set; }

        public Dto()
        {
            this.Occupation = new Occupation.Dto();
            this.ContactInformation = new ContactInformation.Dto();
            this.Mobile = new Mobile.Dto();
        }

    }

}