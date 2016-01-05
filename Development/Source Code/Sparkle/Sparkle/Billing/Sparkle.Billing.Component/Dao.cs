using System;
using System.Data;

namespace Sparkle.Billing.Component
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
            base.CreateStoredProcedure = "Billing.Insert";
            base.ReadStoredProcedure = "Billing.Read";
            base.ReadAllStoredProcedure = "Billing.ReadAll";
            base.UpdateStoredProcedure = "Billing.Update";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Billing.Delete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Date = Convert.IsDBNull(dr["Date"]) ? DateTime.MinValue : Convert.ToDateTime(dr["Date"]);
            dt.Installment = Convert.IsDBNull(dr["Installment"]) ? 0 : Convert.ToInt32(dr["Installment"]);
            dt.FeeAmount = Convert.IsDBNull(dr["FeeAmount"]) ? 0 : Convert.ToDouble(dr["FeeAmount"]);
            dt.FineAmount = Convert.IsDBNull(dr["FineAmount"]) ? 0 : Convert.ToDouble(dr["FineAmount"]);
            dt.TotalAmount = Convert.IsDBNull(dr["TotalAmount"]) ? 0 : Convert.ToDouble(dr["TotalAmount"]);
            dt.AmountPaid = Convert.IsDBNull(dr["AmountPaid"]) ? 0 : Convert.ToDouble(dr["AmountPaid"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Date", DbType.String, (this.Data as Data).Date);
            base.AddInParameter("@Installment", DbType.String, (this.Data as Data).Installment);
            base.AddInParameter("@FeeAmount", DbType.String, (this.Data as Data).FeeAmount);
            base.AddInParameter("@FineAmount", DbType.String, (this.Data as Data).FineAmount);
            base.AddInParameter("@TotalAmount", DbType.String, (this.Data as Data).TotalAmount);
            base.AddInParameter("@AmountPaid", DbType.String, (this.Data as Data).AmountPaid);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Billing.ReadDuplicate");
            this.AssignParameter("Billing.ReadDuplicate");

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