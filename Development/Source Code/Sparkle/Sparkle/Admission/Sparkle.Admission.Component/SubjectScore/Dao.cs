using System;
using System.Data;

namespace Sparkle.Admission.Component.SubjectScore
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
            base.CreateStoredProcedure = "Admission.SubjectScoreInsert";
            base.ReadStoredProcedure = "Admission.SubjectScoreRead";
            base.ReadAllStoredProcedure = "Admission.SubjectScoreReadAll";
            base.UpdateStoredProcedure = "Admission.SubjectScoreUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.SubjectScoreDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Marks = Convert.IsDBNull(dr["Marks"]) ? 0 : Convert.ToInt32(dr["Marks"]);
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Marks", DbType.String, (this.Data as Data).Marks);
        }

        #endregion

            
    }
}