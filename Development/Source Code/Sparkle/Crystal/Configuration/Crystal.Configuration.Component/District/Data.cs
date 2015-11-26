using System;

namespace Crystal.Configuration.Component.District
{

    public class Data : BinAff.Core.Data
    {

        /// <summary>
        /// Name of district
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// State where the district belongs to
        /// </summary>
        public State.Data State { get; set; }

    }

}