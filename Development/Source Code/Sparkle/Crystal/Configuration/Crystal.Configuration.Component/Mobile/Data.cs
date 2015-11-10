using System;

namespace Crystal.Configuration.Component.Mobile
{

    public class Data : BinAff.Core.Data
    {

        public Int32 Number { get; set; }

        public Country.Data Country { get; set; }

    }

}