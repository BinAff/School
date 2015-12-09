using System;

namespace Sparkle.Configuration.Facade.ContactInformation
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        /// <summary>
        /// Address
        /// </summary>
        public String Address { get; set; }

        /// <summary>
        /// District
        /// </summary>
        public District.Dto District { get; set; }

        public Int32 Pin { get; set; }

        public Int32 Landline { get; set; }

        public Dto()
        {
            this.District = new District.Dto();
        }

    }

}