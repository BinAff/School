using System;

namespace Sparkle.Student.Component
{

    public class Data : BinAff.Core.Data
    {

        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }

        public String Address { get; set; }
        public Crystal.Configuration.Component.State.Data State { get; set; }
        public String City { get; set; }
        public Int32 Pin { get; set; }

    }

}