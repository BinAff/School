using System;
using System.Data;

namespace Crystal.Configuration.Component.Category
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
            base.CreateStoredProcedure = "Configuration.CategoryInsert";
            base.ReadStoredProcedure = "Configuration.CategoryRead";
            base.ReadAllStoredProcedure = "Configuration.CategoryReadAll";
            base.UpdateStoredProcedure = "Configuration.CategoryUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Configuration.CategoryDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);

            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
        }

        #endregion

        internal Data ReadDuplicate()
        {
            this.CreateCommand("Configuration.CategoryReadDuplicate");
            this.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
            DataTable dt = this.ExecuteDataTable();
            this.CloseConnection();
            Int64 Id = 0;
            if (dt != null && dt.Rows.Count > 0 && (Id = Convert.IsDBNull(dt.Rows[0]["Id"]) ? 0 : Convert.ToInt64(dt.Rows[0]["Id"])) > 0)
            {
                Data data = new Data();
                new Dao(data).Read();
                return data;
            }
            return null;
        }

    }
}
