using System;

namespace Sparkle.Billing.Facade.Fine.Definition
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Fine Definition
        /// </summary>
        public String Name { get; set; }

        public Boolean IsPercentage { get; set; }

        public Boolean IsActive { get; set; }

    }

}