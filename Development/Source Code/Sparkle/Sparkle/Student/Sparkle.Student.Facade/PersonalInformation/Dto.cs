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

        public Dto()
        {
            this.MotherTongue = new Conf.MotherTongue.Dto();
            this.Religion = new Conf.Religion.Dto();
            this.Caste = new Conf.Caste.Dto();
            this.SubCaste = new Conf.SubCaste.Dto();
            this.Gender = new Conf.Gender.Dto();
            this.CurrentAddress = new Conf.ContactInformation.Dto();
            this.PermanentAddress = new Conf.ContactInformation.Dto();
            this.GuardianList = new List<BinAff.Facade.Library.Dto>();
        }

    }

}