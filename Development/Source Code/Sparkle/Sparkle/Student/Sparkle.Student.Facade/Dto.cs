using System;

using StateFac = Vanilla.Configuration.Facade.State;

namespace Sparkle.Student.Facade
{

    public class Dto : BinAff.Facade.Library.Dto
    {

        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }

        public StateFac.Dto State { get; set; }

    }

}