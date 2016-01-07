using System;
using System.Data;

namespace Sparkle.Admission.Component.Test
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
            base.CreateStoredProcedure = "Admission.TestInsert";
            base.ReadStoredProcedure = "Admission.TestRead";
            base.ReadAllStoredProcedure = "Admission.TestReadAll";
            base.UpdateStoredProcedure = "Admission.TestUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.TestDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.TotalMarks = Convert.IsDBNull(dr["TotalMarks"]) ? 0 : Convert.ToInt32(dr["TotalMarks"]);
            dt.IsPassed = Convert.IsDBNull(dr["IsPassed"]) ? false : Convert.ToBoolean(dr["IsPassed"]);
            dt.Rank = Convert.IsDBNull(dr["Rank"]) ? 0 : Convert.ToInt32(dr["Rank"]);
            dt.IsActive = Convert.IsDBNull(dr["IsActive"]) ? false : Convert.ToBoolean(dr["IsActive"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@TotalMarks", DbType.Int32, (this.Data as Data).TotalMarks);
            base.AddInParameter("@IsPassed", DbType.Boolean, (this.Data as Data).IsPassed);
            base.AddInParameter("@Rank", DbType.Int32, (this.Data as Data).Rank);
            base.AddInParameter("@IsActive", DbType.Boolean, (this.Data as Data).IsActive);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Admission.TestReadDuplicate");
            this.AssignParameter("Admission.TestReadDuplicate");

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

        internal Boolean Activate()
        {
            return UpdateStatus(true);
        }

        internal Boolean Deactivate()
        {
            return UpdateStatus(false);
        }

        internal Boolean UpdateStatus(Boolean ActiveStatus)
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Admission.TestUpdateStatus");
            base.AddInParameter("@Id", DbType.String, (this.Data as Data).Id);
            base.AddInParameter("@IsActive", DbType.Boolean, ActiveStatus);
            return this.ExecuteNonQuery() == 1 ? true : false;
        }
    }
}