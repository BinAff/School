using System;
using System.Data;

namespace Sparkle.Billing.Component.Fine
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
            base.CreateStoredProcedure = "Billing.FineInsert";
            base.ReadStoredProcedure = "Billing.FineRead";
            base.ReadAllStoredProcedure = "Billing.FineReadAll";
            base.UpdateStoredProcedure = "Billing.FineUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Billing.FineDelete";
            base.NumberOfRowsAffectedInDelete = 1;

            base.ReadAllActivateStoredProcedure = "Billing.FineReadAllActive";
            base.UpdateActivationStatusStoredProcedure = "Billing.FineUpdateStatus";
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Amount = Convert.IsDBNull(dr["Amount"]) ? 0.00 : Convert.ToDouble(dr["Amount"]);
            
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
            this.CreateCommand("Billing.FineReadDuplicate");
            this.AssignParameter("Billing.FineReadDuplicate");

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