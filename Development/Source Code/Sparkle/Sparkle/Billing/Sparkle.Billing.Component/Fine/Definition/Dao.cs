using System;
using System.Data;

namespace Sparkle.Billing.Component.Fine.Definition
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
            base.CreateStoredProcedure = "Billing.FineDefinitionInsert";
            base.ReadStoredProcedure = "Billing.FineDefinitionRead";
            base.ReadAllStoredProcedure = "Billing.FineDefinitionReadAll";
            base.UpdateStoredProcedure = "Billing.FineDefinitionUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Billing.FineDefinitionDelete";
            base.NumberOfRowsAffectedInDelete = 1;

            base.ReadAllActivateStoredProcedure = "Billing.FineDefinitionReadAllActive";
            base.UpdateActivationStatusStoredProcedure = "Billing.FineDefinitionUpdateStatus";
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.IsPercentage = Convert.IsDBNull(dr["IsPercentage"]) ? false : Convert.ToBoolean(dr["IsPercentage"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
            base.AddInParameter("@IsPercentage", DbType.String, (this.Data as Data).IsPercentage);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Billing.FineDefinitionReadDuplicate");
            this.AssignParameter("Billing.FineDefinitionReadDuplicate");

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