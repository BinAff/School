using System.Collections.Generic;

using Bil = Sparkle.Billing.Facade;

namespace Sparkle.Billing.Facade.Fee.Definition
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {

        public List<Bil.Fee.Group.Dto> FeeGroupList { get; set; }

        public List<Bil.Fine.Definition.Dto> FineDefinationList { get; set; }
    }

}