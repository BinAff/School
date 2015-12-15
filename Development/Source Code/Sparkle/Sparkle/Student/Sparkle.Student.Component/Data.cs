using System;
using System.Collections.Generic;

namespace Sparkle.Student.Component
{

    public class Data : BinAff.Core.Data
    {

        public String StudentId { get; internal set; }

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Int16 RollNumber { get; set; }

        public Byte[] Photo { get; set; }

        public Category.Data Category { get; set; }

        public Sparkle.School.Component.Standard.Data Standard { get; set; }

        public Sparkle.School.Component.Section.Data Section { get; set; }

        public PersonalInformation.Data PersonalInformation { get; set; }

        public List<BinAff.Core.Data> GuardianList { get; set; }

    }

}