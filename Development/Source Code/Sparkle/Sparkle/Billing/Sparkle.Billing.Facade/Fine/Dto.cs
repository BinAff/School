using System;

using Sch = Sparkle.School.Facade;

namespace Sparkle.Billing.Facade.Fine
{

    public class Dto : Sparkle.Core.Facade.Dto
    {
        public Double Amount { get; set; }

        public Type.Dto FineType { get; set; }

        public Definition.Dto FineDefinition { get; set; }

        public Sch.Standard.Dto SchoolStandard { get; set; }

        public Dto()
        {
            this.FineType = new Type.Dto();
            this.FineDefinition = new Definition.Dto();
            this.SchoolStandard = new Sch.Standard.Dto();
        }
    }

}