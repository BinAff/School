using System;
using System.Data;

namespace Sparkle.Student.Component
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Student.StudentCreate";
            base.ReadStoredProcedure = "Student.StudentRead";
            base.UpdateStoredProcedure = "Student.StudentUpdate";
            base.DeleteStoredProcedure = "Student.StudentDelete";
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.FirstName = Convert.IsDBNull(dr["FirstName"]) ? String.Empty : Convert.ToString(dr["FirstName"]);
            dt.MiddleName = Convert.IsDBNull(dr["MiddleName"]) ? String.Empty : Convert.ToString(dr["MiddleName"]);
            dt.LastName = Convert.IsDBNull(dr["LastName"]) ? String.Empty : Convert.ToString(dr["LastName"]);
            dt.State = new Crystal.Configuration.Component.State.Data
            {
                Id = Convert.IsDBNull(dr["StateId"]) ? 0 : Convert.ToInt64(dr["StateId"]),
            };
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@FirstName", DbType.String, ((Data)this.Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, ((Data)this.Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, ((Data)this.Data).LastName);
            base.AddInParameter("@StateId", DbType.Int64, ((Data)this.Data).State.Id);
        }

    }

}