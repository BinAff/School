using System;

namespace Sparkle.Billing.Component.Concession
{

    public class Data : BinAff.Core.Data
    {

        public Double Amount { get; set; }

        public Boolean IsPercentage { get; set; }

        public Boolean IsActive { get; set; }

    }

}