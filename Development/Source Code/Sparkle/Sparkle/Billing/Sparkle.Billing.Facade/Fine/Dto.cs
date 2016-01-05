using System;

namespace Sparkle.Billing.Facade.Fine
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Fine Amount
        /// </summary>
        public Double Amount { get; set; }

        public Boolean IsActive { get; set; }

    }

}