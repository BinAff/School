using System;

namespace Sparkle.Configuration.Facade.State
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Name of state
        /// </summary>
        public String Name { get; set; }

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