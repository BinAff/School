using System;
using System.Collections.Generic;

namespace Sparkle.Student.Component
{

    public class Data : BinAff.Core.Data
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Sparkle.School.Component.Class.Data Class { get; set; }

        public Sparkle.School.Component.Section.Data Section { get; set; }

        public Int16 RollNumber { get; set; }

        public Byte[] Image { get; set; }

        public Category.Data Category { get; set; }

        public PersonalInformation.Data PersonalInformation { get; set; }

        public Crystal.Configuration.Component.ContactInformation.Data PermanentAddress { get; set; }

        public Crystal.Configuration.Component.ContactInformation.Data ResidentialAddress { get; set; }

        //#region These are just sample, will be deleted

        //public String Address { get; set; }

        //public Crystal.Configuration.Component.State.Data State { get; set; }

        //public String City { get; set; }

        //public Int32 Pin { get; set; }

        //#endregion

    }

}