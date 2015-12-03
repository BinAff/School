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

        ///// <summary>
        ///// Name of district
        ///// </summary>
        //public String Name { get; }

    }

}