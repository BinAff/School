using System;

namespace Sparkle.Student.Facade.ContactInformation.Address
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String Address { get; set; }

        public Vanilla.Configuration.Facade.Country.Dto Country { get; set; }

        public Vanilla.Configuration.Facade.State.Dto State { get; set; }

        public String City { get; set; }

        public Int16 PinCode { get; set; }

    }

}