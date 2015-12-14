using System;
using System.Data;

using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.PersonalInformation
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Student.PersonalInformationInsert";
            base.ReadStoredProcedure = "Student.PersonalInformationRead";
            base.ReadAllStoredProcedure = "Student.PersonalInformationReadAll";
            base.ReadForParentStoredProcedure = "Student.PersonalInformationReadForParent";
            base.UpdateStoredProcedure = "Student.PersonalInformationUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Student.PersonalInformationDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.DateOfBirth = Convert.IsDBNull(dr["DateOfBirth"]) ? DateTime.MinValue : Convert.ToDateTime(dr["DateOfBirth"]);
            dt.BirthPlace = Convert.IsDBNull(dr["BirthPlace"]) ? String.Empty : Convert.ToString(dr["BirthPlace"]);
            dt.MotherTongue = new Conf.MotherTongue.Data
            {
                Id = Convert.IsDBNull(dr["MotherTongueId"]) ? 0 : Convert.ToInt64(dr["MotherTongueId"]),
            };
            dt.Religion = new Conf.Religion.Data
            {
                Id = Convert.IsDBNull(dr["ReligionId"]) ? 0 : Convert.ToInt64(dr["ReligionId"]),
            };
            dt.Caste = new Conf.Caste.Data
            {
                Id = Convert.IsDBNull(dr["CasteId"]) ? 0 : Convert.ToInt64(dr["CasteId"]),
            };
            dt.SubCaste = new Conf.SubCaste.Data
            {
                Id = Convert.IsDBNull(dr["SubCasteId"]) ? 0 : Convert.ToInt64(dr["SubCasteId"]),
            };
            dt.Gender = new Conf.Gender.Data
            {
                Id = Convert.IsDBNull(dr["GenderId"]) ? 0 : Convert.ToInt64(dr["GenderId"]),
            };
            dt.PresentAddress = new Conf.ContactInformation.Data
            {
                Id = Convert.IsDBNull(dr["PresentAddressId"]) ? 0 : Convert.ToInt64(dr["PresentAddressId"]),
            };
            dt.PermanentAddress = new Conf.ContactInformation.Data
            {
                Id = Convert.IsDBNull(dr["PermanentAddressId"]) ? 0 : Convert.ToInt64(dr["PermanentAddressId"]),
            };
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@DateOfBirth", DbType.DateTime, (this.Data as Data).DateOfBirth);
            base.AddInParameter("@BirthPlace", DbType.String, (this.Data as Data).BirthPlace);
            base.AddInParameter("@MotherTongueId", DbType.Int64, (this.Data as Data).MotherTongue.Id);
            base.AddInParameter("@ReligionId", DbType.Int64, (this.Data as Data).Religion.Id);
            base.AddInParameter("@CasteId", DbType.Int64, (this.Data as Data).Caste.Id);
            base.AddInParameter("@SubCasteId", DbType.Int64, (this.Data as Data).SubCaste.Id);
            base.AddInParameter("@GenderId", DbType.Int64, (this.Data as Data).Gender.Id);
            base.AddInParameter("@PresentAddressId", DbType.Int64, (this.Data as Data).PresentAddress.Id);
            base.AddInParameter("@PermanentAddressId", DbType.Int64, (this.Data as Data).PermanentAddress.Id);
            base.AddInParameter("@StudentId", DbType.String, (this.ParentData as Student.Component.Data).Id);
        }

        protected override void AttachChildDataToParent()
        {
            (this.ParentData as Student.Component.Data).PersonalInformation = this.Data as Data;
        }

    }

}