using System.Collections.Generic;
namespace Sparkle.Billing.Facade.Concession
{

    public class FormDto : Sparkle.Core.Facade.FormDto
    {
        public List<Sparkle.Billing.Facade.Fee.Definition.Dto> FeeDefinationList { get; set; }

        public List<Sparkle.Configuration.Facade.Caste.Dto> CasteList { get; set; }

    }

}