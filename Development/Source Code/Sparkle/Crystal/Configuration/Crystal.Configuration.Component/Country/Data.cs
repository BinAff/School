using System;

namespace Crystal.Configuration.Component.Country
{

    public class Data : BinAff.Core.Data
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