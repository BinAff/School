using System;

namespace Crystal.Configuration.Component.Caste
{

    public class Data : BinAff.Core.Data
    {

        public String Name { get; set; }

        public Religion.Data Religion { get; set; }

    }

}