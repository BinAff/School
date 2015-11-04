using System;

using StateFac = Vanilla.Configuration.Facade.State;
using CountryFac = Vanilla.Configuration.Facade.Country;

namespace Sparkle.Student.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        
        public String Address { get; set; }
        public StateFac.Dto State { get; set; }
        public String City { get; set; }
        public Int32 Pin { get; set; }

    }

}