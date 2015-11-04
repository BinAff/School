using System.Collections.Generic;

namespace Sparkle.Core.Facade
{
    public class FormDto : BinAff.Facade.Library.FormDto
    {

        public Dto Dto { get; set; }

        public List<Dto> DtoList { get; set; }

    }

}