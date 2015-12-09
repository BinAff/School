using System.Collections.Generic;

using Schl = Sparkle.School.Facade;

namespace Sparkle.Student.Facade
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Schl.Standard.Dto> StandardList { get; set; }
        public List<Schl.Section.Dto> SectionList { get; set; }

    }

}