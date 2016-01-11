using System;

using Bil = Sparkle.Billing.Component;

namespace Sparkle.Billing.Component.Fee.Definition
{

    public class Data : BinAff.Core.Data
    {
        public String Name { get; set; }

        public Bil.Fee.Group.Data FeeGroup { get; set; }

        public Bil.Fine.Definition.Data FineDefination { get; set; }
        
    }

}