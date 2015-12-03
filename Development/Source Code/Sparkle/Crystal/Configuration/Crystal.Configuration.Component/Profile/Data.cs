using System;

namespace Crystal.Configuration.Component.Profile
{

    public class Data: BinAff.Core.Data
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Occupation.Data Occupation { get; set; }

        public ContactInformation.Data ContactInformation { get; set; }

        public Mobile.Data Mobile { get; set; }

    }

}