using System.Collections.Generic;

using StateFac = Vanilla.Configuration.Facade.State;
using CountryFac = Vanilla.Configuration.Facade.Country;

namespace Sparkle.Student.Facade
{

    public class FormDto : BinAff.Facade.Library.FormDto
    {

        public Dto Dto { get; set; }
        public List<StateFac.Dto> StateList { get; set; }
        public List<CountryFac.Dto> CountryList { get; set; }

    }

}