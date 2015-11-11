using System;

namespace Vanilla.Configuration.Facade.Country
{

    public class Dto : BinAff.Facade.Library.Dto
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