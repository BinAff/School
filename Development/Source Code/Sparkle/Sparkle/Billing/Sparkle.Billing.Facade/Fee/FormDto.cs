using System.Collections.Generic;

using Bil = Sparkle.Billing.Facade;

using Sch = Sparkle.School.Facade;

using Stu = Sparkle.Student.Facade;

namespace Sparkle.Billing.Facade.Fee
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {
        public List<Bil.Fee.Group.Dto> FeeGroupList { get; set; }

        public List<Bil.Fee.Definition.Dto> FeeDefinationList { get; set; }

        public List<Sch.Standard.Dto> SchoolStandardList { get; set; }

        public List<Stu.Category.Dto> CategoryList { get; set; }

    }

}