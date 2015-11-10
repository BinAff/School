using System;
using System.Data;

namespace Crystal.Configuration.Component.State
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data) 
        { 

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Configuration.StateInsert";
            base.NumberOfRowsAffectedInCreate = 1;
            base.ReadStoredProcedure = "Configuration.StateRead";
            base.ReadAllStoredProcedure = "Configuration.StateReadAll";
            base.UpdateStoredProcedure = "Configuration.StateUpdate";
            base.NumberOfRowsAffectedInUpdate = -1;
            base.DeleteStoredProcedure = "Configuration.StateDelete";
            base.NumberOfRowsAffectedInDelete = -1;
        }

        protected override void AssignParameter(string procedureName)
        {
            base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
            base.AddInParameter("@CountryId", DbType.Int64, (this.Data as Data).Country.Id);
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Country = new Country.Data
            {
                Id = Convert.IsDBNull(dr["CountryId"]) ? 0 : Convert.ToInt64(dr["CountryId"]),
            };
            return dt;
        }

        internal Boolean ReadDuplicate()
        {
            Data data = (Data)this.Data;
            this.CreateConnection();
            this.CreateCommand("Configuration.StateReadDuplicate");
            this.AddInParameter("@Name", DbType.String, data.Name);

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