using System;

namespace Sparkle.Admission.Facade.Applicant
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
                
    }

}