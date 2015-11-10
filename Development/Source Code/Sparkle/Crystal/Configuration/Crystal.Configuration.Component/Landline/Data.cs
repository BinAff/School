using System;

namespace Crystal.Configuration.Component.Landline
{

    public class Data : BinAff.Core.Data
    {

        public Int32 StdCode { get; set; }

        public Int32 Number { get; set; }

        public Country.Data Country { get; set; }

    }

}