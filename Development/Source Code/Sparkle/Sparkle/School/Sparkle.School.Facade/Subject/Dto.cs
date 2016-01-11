using System;

namespace Sparkle.School.Facade.Subject
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String Name { get; set; }

        public Int32 TotalMarks { get; set; }

        public Int32 PassMarks { get; set; }

    }

}