using System;
using System.Data;

namespace Crystal.Configuration.Component.Country
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Configuration.CountryInsert";
            base.NumberOfRowsAffectedInCreate = 1;
            base.ReadStoredProcedure = "Configuration.CountryRead";
            base.ReadAllStoredProcedure = "Configuration.CountryReadAll";
            base.UpdateStoredProcedure = "Configuration.CountryUpdate";
            base.NumberOfRowsAffectedInUpdate = -1;
            base.DeleteStoredProcedure = "Configuration.CountryDelete";
            base.NumberOfRowsAffectedInDelete = -1;
        }

        protected override void AssignParameter(String procedureName)
        {
            Data dt = this.Data as Data;
            base.AddInParameter("@Name", DbType.String, dt.Name);
            base.AddInParameter("@Code", DbType.String, dt.Code);
            base.AddInParameter("@IsdCode", DbType.Int16, dt.IsdCode);
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.Code = Convert.IsDBNull(dr["Code"]) ? String.Empty : Convert.ToString(dr["Code"]);
            dt.IsdCode = Convert.IsDBNull(dr["IsdCode"]) ? Convert.ToInt16(0) : Convert.ToInt16(dr["IsdCode"]);
            return dt;
        }

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Configuration.CountryReadDuplicate");
            this.AssignParameter("Configuration.CountryReadDuplicate");

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