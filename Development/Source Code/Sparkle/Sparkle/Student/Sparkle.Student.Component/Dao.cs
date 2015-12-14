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
            //dt.Photo = Convert.IsDBNull(dr["Photo"]) ? Convert.ToByte(null) : Convert.ToByte(dr["Photo"]);

            if (dr["CategoryId"] != null)
            {
                dt.Category = new Category.Data
                {
                    Id = Convert.IsDBNull(dr["CategoryId"]) ? 0 : Convert.ToInt64(dr["CategoryId"])
                };
            }
            if (dr["StandardId"] != null)
            {
                dt.Standard = new Sparkle.School.Component.Standard.Data
                {
                    Id = Convert.IsDBNull(dr["StandardId"]) ? 0 : Convert.ToInt64(dr["StandardId"])
                };
            }
            if (dr["SectionId"] != null)
            {
                dt.Section = new Sparkle.School.Component.Section.Data
                {
                    Id = Convert.IsDBNull(dr["SectionId"]) ? 0 : Convert.ToInt64(dr["SectionId"])
                };
            }
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@StudentId", DbType.String, (this.Data as Data).StudentId);
            base.AddInParameter("@FirstName", DbType.String, (this.Data as Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, (this.Data as Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, (this.Data as Data).LastName);
            base.AddInParameter("@RollNumber", DbType.Int64, (this.Data as Data).RollNumber);
            base.AddInParameter("@Photo", DbType.Byte, (this.Data as Data).Photo);
            base.AddInParameter("@CategoryId", DbType.String, (this.Data as Data).Category.Id);
            base.AddInParameter("@StandardId", DbType.String, (this.Data as Data).Standard.Id);
            base.AddInParameter("@SectionId", DbType.String, (this.Data as Data).Section.Id);
        }

    }

}