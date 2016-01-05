using System;

namespace Sparkle.Billing.Component.Fee.Definition
{

    public class Data : BinAff.Core.Data
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public Boolean IsActive { get; set; }

    }

}