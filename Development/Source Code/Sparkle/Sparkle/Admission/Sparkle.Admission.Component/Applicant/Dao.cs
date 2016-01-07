using System;
using System.Data;

namespace Sparkle.Admission.Component.Applicant
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
            base.CreateStoredProcedure = "Admission.ApplicantInsert";
            base.ReadStoredProcedure = "Admission.ApplicantRead";
            base.ReadAllStoredProcedure = "Admission.ApplicantReadAll";
            base.UpdateStoredProcedure = "Admission.ApplicantUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.ApplicantDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.FirstName = Convert.IsDBNull(dr["FirstName"]) ? String.Empty : Convert.ToString(dr["FirstName"]);
            dt.MiddleName = Convert.IsDBNull(dr["MiddleName"]) ? String.Empty : Convert.ToString(dr["MiddleName"]);
            dt.LastName = Convert.IsDBNull(dr["LastName"]) ? String.Empty : Convert.ToString(dr["LastName"]);
            dt.DateOfBirth = Convert.IsDBNull(dr["DateOfBirth"]) ? DateTime.MinValue : Convert.ToDateTime(dr["DateOfBirth"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@FirstName", DbType.String, (this.Data as Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, (this.Data as Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, (this.Data as Data).LastName);
            base.AddInParameter("@DateOfBirth", DbType.String, (this.Data as Data).DateOfBirth);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Admission.ApplicantReadDuplicate");
            this.AssignParameter("Admission.ApplicantReadDuplicate");

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