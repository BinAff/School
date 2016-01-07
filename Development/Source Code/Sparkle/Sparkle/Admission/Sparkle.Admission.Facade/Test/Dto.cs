using System;

namespace Sparkle.Admission.Facade.Test
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Int32 TotalMarks { get; set; }

        public Boolean IsPassed { get; set; }

        public Int32 Rank { get; set; }

    }

}