using System;
using System.Data;

namespace Sparkle.Billing.Component.Concession
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
            base.CreateStoredProcedure = "Billing.ConcessionInsert";
            base.ReadStoredProcedure = "Billing.ConcessionRead";
            base.ReadAllStoredProcedure = "Billing.ConcessionReadAll";
            base.UpdateStoredProcedure = "Billing.ConcessionUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Billing.ConcessionDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Amount = Convert.IsDBNull(dr["Amount"]) ? 0.00 : Convert.ToDouble(dr["Amount"]);
            dt.IsPercentage = Convert.IsDBNull(dr["IsPercentage"]) ? false : Convert.ToBoolean(dr["IsPercentage"]);
            dt.IsActive = Convert.IsDBNull(dr["IsActive"]) ? false : Convert.ToBoolean(dr["IsActive"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Amount", DbType.String, (this.Data as Data).Amount);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Billing.ConcessionReadDuplicate");
            this.AssignParameter("Billing.ConcessionReadDuplicate");

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
            this.CreateCommand("Billing.ConcessionUpdateStatus");
            base.AddInParameter("@Id", DbType.String, (this.Data as Data).Id);
            base.AddInParameter("@IsActive", DbType.Boolean, ActiveStatus);
            return this.ExecuteNonQuery() == 1 ? true : false;
        }

    }

}