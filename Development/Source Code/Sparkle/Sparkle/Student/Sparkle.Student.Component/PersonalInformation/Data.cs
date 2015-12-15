using System;
using System.Collections.Generic;

using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.PersonalInformation
{

    public class Data:BinAff.Core.Data
    {

        public DateTime DateOfBirth { get; set; }

        public String BirthPlace { get; set; }

        public Conf.MotherTongue.Data MotherTongue { get; set; }

        public Conf.Religion.Data Religion { get; set; }

        public Conf.Caste.Data Caste { get; set; }

        public Conf.SubCaste.Data SubCaste { get; set; }

        public Conf.Gender.Data Gender { get; set; }

        public Conf.ContactInformation.Data PresentAddress { get; set; }

        public Conf.ContactInformation.Data PermanentAddress { get; set; }

    }

}