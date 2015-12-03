using System;
using System.Data;

namespace Crystal.Configuration.Component.Profile
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Configuration.ProfileInsert";
            base.NumberOfRowsAffectedInCreate = 1;
            base.ReadStoredProcedure = "Configuration.ProfileRead";
            base.ReadAllStoredProcedure = "Configuration.ProfileReadAll";
            base.UpdateStoredProcedure = "Configuration.ProfileUpdate";
            base.NumberOfRowsAffectedInUpdate = -1;
            base.DeleteStoredProcedure = "Configuration.ProfileDelete";
            base.NumberOfRowsAffectedInDelete = -1;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@FirstName", DbType.String, (this.Data as Data).FirstName);
            base.AddInParameter("@MiddleName", DbType.String, (this.Data as Data).MiddleName);
            base.AddInParameter("@LastName", DbType.String, (this.Data as Data).LastName);
            base.AddInParameter("@OccupationId", DbType.Int64, (this.Data as Data).Occupation.Id);
            base.AddInParameter("@ContactInformationId", DbType.Int32, (this.Data as Data).ContactInformation.Id);
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.FirstName = Convert.IsDBNull(dr["FirstName"]) ? String.Empty : Convert.ToString(dr["FirstName"]);
            dt.MiddleName = Convert.IsDBNull(dr["MiddleName"]) ? String.Empty : Convert.ToString(dr["MiddleName"]);
            dt.LastName = Convert.IsDBNull(dr["LastName"]) ? String.Empty : Convert.ToString(dr["LastName"]);
            dt.Occupation = new Occupation.Data
            {
                Id = Convert.IsDBNull(dr["OccupationId"]) ? 0 : Convert.ToInt64(dr["OccupationId"]),
            };
            dt.ContactInformation = new ContactInformation.Data
            {
                Id = Convert.IsDBNull(dr["ContactInformationId"]) ? 0 : Convert.ToInt64(dr["ContactInformationId"]),
            };
            return dt;
        }

    }

}