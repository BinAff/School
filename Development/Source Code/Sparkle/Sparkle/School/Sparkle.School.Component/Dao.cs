using System;
using System.Data;

namespace Sparkle.School.Component
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
            base.CreateStoredProcedure = "School.Insert";
            base.ReadStoredProcedure = "School.Read";
            base.ReadAllStoredProcedure = "School.ReadAll";
            base.UpdateStoredProcedure = "School.Update";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "School.Delete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.Logo = Convert.IsDBNull(dr["Logo"]) ? String.Empty : Convert.ToString(dr["Logo"]);
            dt.AccreditationNumber = Convert.IsDBNull(dr["AccreditationNumber"]) ? String.Empty : Convert.ToString(dr["AccreditationNumber"]);
            dt.Tan = Convert.IsDBNull(dr["Tan"]) ? String.Empty : Convert.ToString(dr["Tan"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            //base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
        }

        #endregion

        //internal Boolean ReadDuplicate()
        //{
        //    Data data = this.Data as Data;
        //    this.CreateConnection();
        //    this.CreateCommand("School.ReadDuplicate");
        //    this.AssignParameter("School.ReadDuplicate");

        //    DataSet ds = this.ExecuteDataSet();

        //    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            if (!Convert.IsDBNull(dr["Id"]) && Convert.ToInt64(dr["Id"]) != this.Data.Id) return true;
        //        }
        //    }

        //    return false;
        //}

    }

}