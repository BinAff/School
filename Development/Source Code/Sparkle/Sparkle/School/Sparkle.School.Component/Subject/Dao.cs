using System;
using System.Data;

namespace Sparkle.School.Component.Subject
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
            base.CreateStoredProcedure = "School.SubjectInsert";
            base.ReadStoredProcedure = "School.SubjectRead";
            base.ReadAllStoredProcedure = "School.SubjectReadAll";
            base.UpdateStoredProcedure = "School.SubjectUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "School.SubjectDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.TotalMarks = Convert.IsDBNull(dr["TotalMarks"]) ? 0 : Convert.ToInt32(dr["TotalMarks"]);
            dt.PassMarks = Convert.IsDBNull(dr["PassMarks"]) ? 0 : Convert.ToInt32(dr["PassMarks"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
            base.AddInParameter("@TotalMarks", DbType.String, (this.Data as Data).TotalMarks);
            base.AddInParameter("@PassMarks", DbType.String, (this.Data as Data).PassMarks);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("School.SubjectReadDuplicate");
            this.AssignParameter("School.SubjectReadDuplicate");

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