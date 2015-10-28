using System.Collections.Generic;

using StateFac = Vanilla.Configuration.Facade.State;

namespace Sparkle.Student.Facade
{

    public class FormDto : BinAff.Facade.Library.FormDto
    {

        public Dto Dto { get; set; }
        public List<StateFac.Dto> StateList { get; set; }

    }

}