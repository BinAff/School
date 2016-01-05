using System;

namespace Sparkle.Billing.Facade.Fee.Definition
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Fee Definition
        /// </summary>
        public String Name { get; set; }

        public Boolean IsActive { get; set; }

    }

}