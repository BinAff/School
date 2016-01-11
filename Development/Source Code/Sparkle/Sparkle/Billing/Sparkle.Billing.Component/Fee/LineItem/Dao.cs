using System;
using System.Data;

namespace Sparkle.Billing.Component.Fee.LineItem
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
            base.CreateStoredProcedure = "Billing.FeeLineItemInsert";
            base.ReadStoredProcedure = "Billing.FeeLineItemRead";
            base.ReadAllStoredProcedure = "Billing.FeeLineItemReadAll";
            base.UpdateStoredProcedure = "Billing.FeeLineItemUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Billing.FeeLineItemDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Installment = Convert.IsDBNull(dr["Installment"]) ? 0 : Convert.ToInt32(dr["Installment"]);
            dt.Amount = Convert.IsDBNull(dr["Amount"]) ? 0.00 : Convert.ToDouble(dr["Amount"]);
            
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Installment", DbType.Int32, (this.Data as Data).Installment);
            base.AddInParameter("@Amount", DbType.Double, (this.Data as Data).Amount);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Billing.FeeLineItemReadDuplicate");
            this.AssignParameter("Billing.FeeLineItemReadDuplicate");

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