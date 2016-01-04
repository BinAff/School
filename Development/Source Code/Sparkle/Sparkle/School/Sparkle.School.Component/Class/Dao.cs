using System;
using System.Data;

namespace Sparkle.School.Component.Class
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        #region Framework

        protected override void Compose()
        {
            base.CreateStoredProcedure = "School.ClassInsert";
            base.ReadStoredProcedure = "School.ClassRead";
            base.ReadAllStoredProcedure = "School.ClassReadAll";
            base.UpdateStoredProcedure = "School.ClassUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "School.ClassDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Standard = new Standard.Data
            {
                Id = Convert.IsDBNull(dr["StandardId"]) ? 0 : Convert.ToInt64(dr["StandardId"]),
            };
            dt.Section = new Section.Data
            {
                Id = Convert.IsDBNull(dr["SectionId"]) ? 0 : Convert.ToInt64(dr["SectionId"]),
            };
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            Data data = this.Data as Data;
            this.AddInParameter("@StandardId", DbType.String, data.Standard.Id);
            this.AddInParameter("@SectionId", DbType.String, data.Section.Id);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("School.ClassReadDuplicate");
            this.AssignParameter("School.ClassReadDuplicate");

            DataSet ds = this.ExecuteDataSet();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (!Convert.IsDBNull(dr["Id"]) && Convert.ToInt64(dr["Id"]) != this.Data.Id) return true;
                }
            }

            return false;
        }

    }

}