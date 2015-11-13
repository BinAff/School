using System;
using System.Data;

namespace Crystal.Configuration.Component.ContactInformation
{
    public class Dao : BinAff.Core.Dao
    {
        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Configuration.ContactInformationInsert";
            base.NumberOfRowsAffectedInCreate = 1;
            base.ReadStoredProcedure = "Configuration.ContactInformationRead";
            base.ReadAllStoredProcedure = "Configuration.ContactInformationReadAll";
            base.UpdateStoredProcedure = "Configuration.ContactInformationUpdate";
            base.NumberOfRowsAffectedInUpdate = -1;
            base.DeleteStoredProcedure = "Configuration.ContactInformationDelete";
            base.NumberOfRowsAffectedInDelete = -1;
        }

        protected override void AssignParameter(string procedureName)
        {
            base.AddInParameter("@Address", DbType.String, (this.Data as Data).Address);
            base.AddInParameter("@StateId", DbType.Int64, (this.Data as Data).State.Id);
            base.AddInParameter("@City", DbType.String, (this.Data as Data).City);
            base.AddInParameter("@Pin", DbType.Int32, (this.Data as Data).Pin);
            base.AddInParameter("@LandlineNumberList", DbType.Int64, (this.Data as Data).LandlineNumberList);
            base.AddInParameter("@MobileNumberList", DbType.Int64, (this.Data as Data).MobileNumberList);
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Address = Convert.IsDBNull(dr["Address"]) ? String.Empty : Convert.ToString(dr["Address"]);
            dt.City = Convert.IsDBNull(dr["City"]) ? String.Empty : Convert.ToString(dr["City"]);
            dt.Pin = Convert.IsDBNull(dr["Pin"]) ? 0 : Convert.ToInt32(dr["Pin"]);
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.State = new State.Data
            {
                Id = Convert.IsDBNull(dr["StateId"]) ? 0 : Convert.ToInt64(dr["StateId"]),
            };
            return dt;
        }

        

    }
}
