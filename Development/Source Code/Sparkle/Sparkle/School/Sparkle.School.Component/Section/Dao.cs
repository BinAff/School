using System;
using System.Data;

namespace Sparkle.School.Component.Section
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
            base.CreateStoredProcedure = "Configuration.SectionInsert";
            base.ReadStoredProcedure = "Configuration.SectionRead";
            base.ReadAllStoredProcedure = "Configuration.SectionReadAll";
            base.UpdateStoredProcedure = "Configuration.SectionUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Configuration.SectionDelete";
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
            this.CreateCommand("Configuration.SectionReadDuplicate");
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