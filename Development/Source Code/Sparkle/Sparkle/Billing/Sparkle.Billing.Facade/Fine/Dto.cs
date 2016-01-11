using System;

using Sch = Sparkle.School.Facade;

namespace Sparkle.Billing.Facade.Fine
{

    public class Dto : Sparkle.Core.Facade.Dto
    {
        public Double Amount { get; set; }

        //public Type.Dto Type { get; set; }

        public Definition.Dto Definition { get; set; }

        public Sch.Standard.Dto SchoolStandard { get; set; }

        public Dto()
        {
            //this.Type = new Type.Dto();
            this.Definition = new Definition.Dto();
            this.SchoolStandard = new Sch.Standard.Dto();
        }
    }

}