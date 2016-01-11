using System;

using Bil = Sparkle.Billing.Component;

namespace Sparkle.Billing.Component.Fee.Definition
{

    public class Data : BinAff.Core.Data
    {
        public String Name { get; set; }

        public Group.Data FeeGroup { get; set; }

        public Bil.Fine.Definition.Data FineDefination { get; set; }

        public Data()
        {
            FeeGroup = new Group.Data();
            FineDefination = new Fine.Definition.Data();
        }
    }

}