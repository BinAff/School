using System;

using Fac = Sparkle.Billing.Component.Fine;

using Sch = Sparkle.School.Component;

namespace Sparkle.Billing.Component.Fine
{

    public class Data : BinAff.Core.Data
    {
        public Double Amount { get; set; }

        public Fac.Definition.Data Definition { get; set; }

        public Sch.Standard.Data SchoolStandard { get; set; }

        public Data()
        {
            this.Definition = new Definition.Data();
            this.SchoolStandard = new Sch.Standard.Data();
        }

    }

}