using System;
using System.Data;

namespace Sparkle.Admission.Component
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
            base.CreateStoredProcedure = "Admission.Insert";
            base.ReadStoredProcedure = "Admission.Read";
            base.ReadAllStoredProcedure = "Admission.ReadAll";
            base.UpdateStoredProcedure = "Admission.Update";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.Delete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            
        }

        #endregion

        //internal Boolean ReadDuplicate()
        //{
        //    return false;
        //}
    }
}