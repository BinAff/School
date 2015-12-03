using System;

namespace Crystal.Configuration.Component.ContactInformation
{

    public class Data: BinAff.Core.Data
    {

        public String Address { get; set; }

        public District.Data District { get; set; }

        public Int32 Pin { get; set; }

        public Int32 Landline { get; set; }

    }

}