using System;

namespace Sparkle.Student.Component
{

    public class Data : BinAff.Core.Data
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Int16 RollNumber { get; set; }

        public Byte[] Image { get; set; }

        public Category.Data Category { get; set; }

        public Sparkle.School.Component.Class.Data Class { get; set; }

        public PersonalInformation.Data PersonalInformation { get; set; }

    }

}