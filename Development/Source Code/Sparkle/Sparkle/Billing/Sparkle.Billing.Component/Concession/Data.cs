using System;
using Comp = Crystal.Configuration.Component.Caste;
namespace Sparkle.Billing.Component.Concession
{

    public class Data : BinAff.Core.Data
    {
        public Fee.Definition.Data FeeDefinition { get; set; }

        public Comp.Data Caste { get; set; }

        public Double Amount { get; set; }

        public Boolean IsPercentage { get; set; }

        public Data()
        {
            FeeDefinition = new Fee.Definition.Data();
            Caste = new Comp.Data();
        }
    }

}