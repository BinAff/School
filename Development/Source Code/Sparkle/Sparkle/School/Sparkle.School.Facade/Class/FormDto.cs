using System.Collections.Generic;

namespace Sparkle.School.Facade.Class
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Standard.Dto> StandardList { get; set; }

        public List<Section.Dto> SectionList { get; set; }

    }

}