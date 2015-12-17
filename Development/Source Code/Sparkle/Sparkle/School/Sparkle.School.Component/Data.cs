using System;

namespace Sparkle.School.Component
{

    public class Data : BinAff.Core.Data
    {

        public String Name { get; set; }

        public Crystal.Configuration.Component.ContactInformation.Data ContactInformation { get; set; }

    }

}