using System;

using Fac = Sparkle.Billing.Component.Fine;

using Sch = Sparkle.School.Component;

namespace Sparkle.Billing.Component.Fine
{

    public class Data : BinAff.Core.Data
    {
        public Double Amount { get; set; }

        public Fac.Type.Data FineType { get; set; }

        public Fac.Definition.Data FineDefinition { get; set; }

        public Sch.Standard.Data SchoolStandard { get; set; }

        public Data()
        {
            this.FineType = new Type.Data();
            this.FineDefinition = new Definition.Data();
            this.SchoolStandard = new Sch.Standard.Data();
        }
    }

}