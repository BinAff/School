﻿using System.Collections.Generic;

namespace Vanilla.Configuration.Facade.Country
{

    public class FormDto : BinAff.Facade.Library.FormDto
    {

        public Dto Dto { get; set; }

        public List<Dto> DtoList { get; set; }

    }

}