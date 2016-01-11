using System;

namespace Sparkle.Billing.Facade.Concession
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public Fee.Definition.Dto FeeDefinition { get; set; }

        public Configuration.Facade.Caste.Dto Caste { get; set; }
        
        public Double Amount { get; set; }

        public Boolean IsPercentage { get; set; }

        public Dto()
        {
            FeeDefinition = new Fee.Definition.Dto();
            Caste = new Configuration.Facade.Caste.Dto();
        }

    }

}