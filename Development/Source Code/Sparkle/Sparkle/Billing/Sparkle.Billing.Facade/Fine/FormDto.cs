using System.Collections.Generic;

using Sch = Sparkle.School.Facade;

namespace Sparkle.Billing.Facade.Fine
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {
        public List<Type.Dto> FineTypeList { get; set; }
        public List<Definition.Dto> FineDefinitionList { get; set; }
        public List<Sch.Standard.Dto> SchoolStandardList { get; set; }

    }

}