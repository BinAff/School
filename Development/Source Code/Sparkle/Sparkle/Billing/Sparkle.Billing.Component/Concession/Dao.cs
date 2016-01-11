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

            base.ReadAllActivateStoredProcedure = "Billing.ConcessionReadAllActive";
            base.UpdateActivationStatusStoredProcedure = "Billing.ConcessionUpdateStatus";
            
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Amount = Convert.IsDBNull(dr["Amount"]) ? 0.00 : Convert.ToDouble(dr["Amount"]);
            dt.IsPercentage = Convert.IsDBNull(dr["IsPercentage"]) ? false : Convert.ToBoolean(dr["IsPercentage"]);
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
    }
}