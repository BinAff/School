using System;

namespace Sparkle.Billing.Facade.Fee.LineItem
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Fee LineItem
        /// </summary>
        public Int32 Installment { get; set; }

        public Double Amount { get; set; }

    }

}