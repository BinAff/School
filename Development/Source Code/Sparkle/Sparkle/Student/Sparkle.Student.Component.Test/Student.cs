using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Conf = Crystal.Configuration.Component;

using Stud = Sparkle.Student.Component;
using Schl = Sparkle.School.Component;

namespace Sparkle.Student.Component.Test
{
    [TestClass]
    public class Student
    {
        [TestMethod]
        public void Save()
        {
            Data data = new Data
            {
                FirstName = "Arighna",
                MiddleName = "",
                LastName = "Kar",
                Standard = new Schl.Standard.Data { Id = 1 },
                Section = new Schl.Section.Data { Id = 1 },
                RollNumber = 1,
                Category = new Category.Data { Id = 1 },
                PersonalInformation = new PersonalInformation.Data
                {
                    DateOfBirth = DateTime.Today.Subtract(new TimeSpan(7300, 0, 0, 0)),
                    BirthPlace = "Bagnan",
                    Caste = new Conf.Caste.Data { Id = 1 },
                    SubCaste = new Conf.SubCaste.Data { Id = 1 },
                    MotherTongue = new Conf.MotherTongue.Data { Id = 1 },
                    Religion = new Conf.Religion.Data { Id = 1 },
                    Gender = new Conf.Gender.Data { Id = 1 },
                    PresentAddress = new Conf.ContactInformation.Data
                    {
                        Address = "Kodichikkanhalli",
                        District = new Conf.District.Data
                        {
                            Id = 1,
                        },
                        Pin = 560076,
                    },
                    PermanentAddress = new Conf.ContactInformation.Data
                    {
                        Address = "Boalia",
                        District = new Conf.District.Data { Id = 2 },
                        Pin = 700084,
                    },                    
                },
                GuardianList = new System.Collections.Generic.List<BinAff.Core.Data>
                {
                    new Stud.Guardian.Data
                    {
                        Profile = new Conf.Profile.Data
                        {
                            FirstName = "Ajoy",
                            LastName = "Kar",
                            Mobile = new Conf.Mobile.Data
                            {
                                Number = 9875403258,
                                Country = new Conf.Country.Data { Id = 2},
                            },
                            Occupation = new Conf.Occupation.Data { Id = 1},
                            ContactInformation = new Conf.ContactInformation.Data
                            {
                                Address = "Garia",
                                District = new Conf.District.Data { Id = 1 },
                                Pin = 700084
                            },
                        },
                        Relationship = new Conf.Relationship.Data { Id = 1},
                    }
                },
            };
            BinAff.Core.Crud server = new Server(data);
            server.DataAccess.ConnectionString = @"Data Source=.\BinAff;Initial Catalog=Sparkle;Integrated Security=True;";
            BinAff.Core.ReturnObject<Boolean> ret = (server as BinAff.Core.ICrud).Save();
            Assert.AreEqual(ret.Value, true);
        }
    }
}