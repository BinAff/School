using System;

namespace Sparkle.Configuration.Facade.Mobile
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Mobile number
        /// </summary>
        public Int64 Number { get; set; }

        /// <summary>
        /// Country where the state belongs to
        /// </summary>
        public Country.Dto Country { get; set; }

        public Dto()
        {
            this.Country = new Country.Dto();
        }

    }

}