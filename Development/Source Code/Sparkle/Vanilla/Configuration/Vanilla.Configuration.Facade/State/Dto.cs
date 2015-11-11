using System;

namespace Vanilla.Configuration.Facade.State
{

    public class Dto : BinAff.Facade.Library.Dto
    {

        /// <summary>
        /// Name of state
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Country where the state belongs to
        /// </summary>
        public Country.Dto Country { get; set; }

    }

}