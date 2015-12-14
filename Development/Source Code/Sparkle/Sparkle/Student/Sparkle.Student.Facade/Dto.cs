using System;

using Schl = Sparkle.School.Facade;

namespace Sparkle.Student.Facade
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public Int16 RollNumber { get; set; }

        public Byte[] Image { get; set; }

        public Category.Dto Category { get; set; }

        public Schl.Standard.Dto Standard { get; set; }

        public Schl.Section.Dto Section { get; set; }

        public PersonalInformation.Dto PersonalInformation { get; set; }

        public Dto()
        {
            this.Category = new Category.Dto();
            this.Standard = new Schl.Standard.Dto();
            this.Section = new Schl.Section.Dto();
            this.PersonalInformation = new PersonalInformation.Dto();
        }

    }

}