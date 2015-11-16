using System;

namespace Sparkle.Configuration.Facade.Country
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Name of country
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        public String Code { get; set; }

        /// <summary>
        /// ISD code
        /// </summary>
        public Int16 IsdCode { get; set; }

    }

}