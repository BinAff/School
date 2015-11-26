using System;

namespace Sparkle.Configuration.Facade.District
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Name of district
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// State where the district belongs to
        /// </summary>
        public State.Dto State { get; set; }

    }

}