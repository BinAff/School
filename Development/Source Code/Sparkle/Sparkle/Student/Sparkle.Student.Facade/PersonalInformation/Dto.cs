using System;
using System.Collections.Generic;

using Conf = Sparkle.Configuration.Facade;

namespace Sparkle.Student.Facade.PersonalInformation
{

    public class Dto : Sparkle.Core.Facade.Dto
    {

        public DateTime DateOfBirth { get; set; }

        public String BirthPlace { get; set; }

        public Conf.MotherTongue.Dto MotherTongue { get; set; }

        public Conf.Religion.Dto Religion { get; set; }

        public Conf.Caste.Dto Caste { get; set; }

        public Conf.SubCaste.Dto SubCaste { get; set; }

        public Conf.Gender.Dto Gender { get; set; }

        public Conf.ContactInformation.Dto CurrentAddress { get; set; }

        public Conf.ContactInformation.Dto PermanentAddress { get; set; }

        public List<BinAff.Facade.Library.Dto> GuardianList { get; set; }

    }

}