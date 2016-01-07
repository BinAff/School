using System;
using System.Data;

namespace Sparkle.Admission.Component.AdmissionForm
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
            base.CreateStoredProcedure = "Admission.AdmissionFormInsert";
            base.ReadStoredProcedure = "Admission.AdmissionFormRead";
            base.ReadAllStoredProcedure = "Admission.AdmissionFormReadAll";
            base.UpdateStoredProcedure = "Admission.AdmissionFormUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.AdmissionFormDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Number = Convert.IsDBNull(dr["Number"]) ? String.Empty : Convert.ToString(dr["Number"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Number", DbType.String, (this.Data as Data).Number);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Admission.AdmissionFormReadDuplicate");
            this.AssignParameter("Admission.AdmissionFormReadDuplicate");

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