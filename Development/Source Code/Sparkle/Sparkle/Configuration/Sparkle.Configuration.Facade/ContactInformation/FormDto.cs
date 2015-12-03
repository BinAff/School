using System.Collections.Generic;

namespace Sparkle.Configuration.Facade.ContactInformation
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Country.Dto> CountryList { get; set; }
        public List<State.Dto> StateList { get; set; }
        public List<District.Dto> DistrictList { get; set; }

    }

}