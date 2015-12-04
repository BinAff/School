using System;
using System.Data;

namespace Sparkle.Student.Component
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Student.StudentInsert";
            base.ReadStoredProcedure = "Student.StudentRead";
            base.ReadAllStoredProcedure = "Student.StudentReadAll";
            base.UpdateStoredProcedure = "Student.StudentUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Student.StudentDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.FirstName = Convert.IsDBNull(dr["FirstName"]) ? String.Empty : Convert.ToString(dr["FirstName"]);
            dt.MiddleName = Convert.IsDBNull(dr["MiddleName"]) ? String.Empty : Convert.ToString(dr["MiddleName"]);
            dt.LastName = Convert.IsDBNull(dr["LastName"]) ? String.Empty : Convert.ToString(dr["LastName"]);
            dt.RollNumber = Convert.IsDBNull(dr["RollNumber"]) ? Convert.ToInt16(0) : Convert.ToInt16(dr["RollNumber"]);
            //dt.Image = Convert.IsDBNull(dr["Image"]) ? Convert.ToByte(null) : Convert.ToByte(dr["Image"]);

            if (dr["CategoryId"] != null)
            {
                dt.Category = new Category.Data
                {
                    Id = Convert.IsDBNull(dr["CategoryId"]) ? 0 : Convert.ToInt64(dr["CategoryId"])
                };
            }
            if (dr["ClassId"] != null)
            {
                dt.Class = new Sparkle.School.Component.Class.Data
                {
                    Id = Convert.IsDBNull(dr["ClassId"]) ? 0 : Convert.ToInt64(dr["ClassId"])
                };
            }
            if (dr["PersonalInformationId"] != null)
            {
                dt.PersonalInformation = new PersonalInformation.Data
                {
                    Id = Convert.IsDBNull(dr["PersonalInformationId"]) ? 0 : Convert.ToInt64(dr["PersonalInformationId"])
                };
            }
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@FirstName", DbType.String, (this.Data as Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, (this.Data as Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, (this.Data as Data).LastName);
            base.AddInParameter("@RollNumber", DbType.Int64, (this.Data as Data).RollNumber);
            base.AddInParameter("@Image", DbType.Byte, (this.Data as Data).Image);
            base.AddInParameter("@CategoryId", DbType.String, (this.Data as Data).Category.Id);
            base.AddInParameter("@ClassId", DbType.String, (this.Data as Data).Class.Id);
            base.AddInParameter("@PersonalInformationId", DbType.String, (this.Data as Data).PersonalInformation.Id);
        }

    }

}