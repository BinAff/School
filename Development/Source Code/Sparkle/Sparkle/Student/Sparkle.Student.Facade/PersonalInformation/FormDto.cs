using System.Collections.Generic;

using Conf = Sparkle.Configuration.Facade;

namespace Sparkle.Student.Facade.PersonalInformation
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Conf.MotherTongue.Dto> MotherTongueList { get; set; }
        public List<Conf.Religion.Dto> ReligionList { get; set; }
        public List<Conf.Caste.Dto> CasteList { get; set; }
        public List<Conf.SubCaste.Dto> SubCasteList { get; set; }
        public List<Conf.Gender.Dto> GenderList { get; set; }

    }

}