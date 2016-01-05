using System;

namespace Sparkle.Billing.Facade.Concession
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Fee LineItem
        /// </summary>
        
        public Double Amount { get; set; }

        public Boolean IsPercentage { get; set; }

        public Boolean IsActive { get; set; }

    }

}