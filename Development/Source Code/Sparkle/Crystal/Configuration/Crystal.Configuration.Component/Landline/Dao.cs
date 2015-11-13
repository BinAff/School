using System;
using System.Data;

namespace Crystal.Configuration.Component.Landline
{
    public class Dao : BinAff.Core.Dao
    {
        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Configuration.LandlineInsert";
            base.NumberOfRowsAffectedInCreate = 1;
            base.ReadStoredProcedure = "Configuration.LandlineRead";
            base.ReadAllStoredProcedure = "Configuration.LandlineReadAll";
            base.UpdateStoredProcedure = "Configuration.LandlineUpdate";
            base.NumberOfRowsAffectedInUpdate = -1;
            base.DeleteStoredProcedure = "Configuration.LandlineDelete";
            base.NumberOfRowsAffectedInDelete = -1;
        }

        protected override void AssignParameter(string procedureName)
        {
            base.AddInParameter("@StdCode", DbType.Int64, (this.Data as Data).StdCode);
            base.AddInParameter("@Number", DbType.Int64, (this.Data as Data).Number);
            base.AddInParameter("@CountryId", DbType.Int64, (this.Data as Data).Country.Id);
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Id = Convert.IsDBNull(dr["StdCode"]) ? 0 : Convert.ToInt64(dr["StdCode"]);
            dt.Id = Convert.IsDBNull(dr["Number"]) ? 0 : Convert.ToInt64(dr["Number"]);
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
            this.CreateCommand("Configuration.LandlineReadDuplicate");
            this.AddInParameter("@StdCode", DbType.Int64, data.StdCode);
            this.AddInParameter("@Number", DbType.Int64, data.Number);

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
