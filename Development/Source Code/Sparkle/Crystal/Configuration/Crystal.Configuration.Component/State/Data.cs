using System;

namespace Crystal.Configuration.Component.State
{

    public class Data : BinAff.Core.Data
    {

        /// <summary>
        /// Name of state
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Country where the state belongs to
        /// </summary>
        public Country.Data Country { get; set; }

    }

}