using System;

namespace Sparkle.Billing.Component.Fee
{

    public class Data : BinAff.Core.Data
    {

        public Double Amount { get; set; }

        public Sparkle.School.Component.Standard.Data Standard { get; set; }

        public Sparkle.School.Component.Section.Data Section { get; set; }

    }

}