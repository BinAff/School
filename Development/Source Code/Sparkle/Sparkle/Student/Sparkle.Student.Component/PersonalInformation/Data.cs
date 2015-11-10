using System;

using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.PersonalInformation
{

    public class Data:BinAff.Core.Data
    {

        public DateTime DateOfBirth { get; set; }
        //Other properties from diagram

        public Conf.Gender.Data Gender { get; set; }

        public Conf.Religion.Data Religion { get; set; }

        public Conf.Caste.Data Caste { get; set; }

        public Conf.SubCaste.Data SubCaste { get; set; }

    }

}