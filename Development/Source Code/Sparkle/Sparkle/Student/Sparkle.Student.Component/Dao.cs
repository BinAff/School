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
            base.CreateStoredProcedure = "Student.StudentInsert";
            base.ReadStoredProcedure = "Student.StudentRead";
            base.ReadAllStoredProcedure = "Student.StudentReadAll";
            base.UpdateStoredProcedure = "Student.StudentUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Student.StudentDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.FirstName = Convert.IsDBNull(dr["FirstName"]) ? String.Empty : Convert.ToString(dr["FirstName"]);
            dt.MiddleName = Convert.IsDBNull(dr["MiddleName"]) ? String.Empty : Convert.ToString(dr["MiddleName"]);
            dt.LastName = Convert.IsDBNull(dr["LastName"]) ? String.Empty : Convert.ToString(dr["LastName"]);
            
            //This place has to change...
            dt.ResidentialAddress.Address = Convert.IsDBNull(dr["Address"]) ? String.Empty : Convert.ToString(dr["Address"]);
            //dt.ResidentialAddress.State = new Crystal.Configuration.Component.State.Data
            //{
            //    Id = Convert.IsDBNull(dr["StateId"]) ? 0 : Convert.ToInt64(dr["StateId"]),
            //};
            //dt.ResidentialAddress.City = Convert.IsDBNull(dr["City"]) ? String.Empty : Convert.ToString(dr["City"]);
            dt.ResidentialAddress.Pin = Convert.IsDBNull(dr["Pin"]) ? 0 : Convert.ToInt32(dr["Pin"]);
            //...
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@FirstName", DbType.String, (this.Data as Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, (this.Data as Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, (this.Data as Data).LastName);

            base.AddInParameter("@Address", DbType.String, (this.Data as Data).ResidentialAddress.Address);
            //base.AddInParameter("@StateId", DbType.Int64, (this.Data as Data).ResidentialAddress.State.Id);
            //base.AddInParameter("@City", DbType.String, (this.Data as Data).ResidentialAddress.City);
            base.AddInParameter("@Pin", DbType.Int32, (this.Data as Data).ResidentialAddress.Pin);
        }

    }

}