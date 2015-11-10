using System;
using System.Collections.Generic;

namespace Crystal.Configuration.Component.ContactInformation
{

    public class Data: BinAff.Core.Data
    {

        public String Address { get; set; }

        public State.Data State { get; set; }

        public String City { get; set; }

        public Int32 Pin { get; set; }

        public List<Landline.Data> LandlineNumberList { get; set; }

        public List<Mobile.Data> MobileNumberList { get; set; }

    }

}