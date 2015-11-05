using System;
using System.Data;

namespace Crystal.Configuration.Component.Religion
{
   public class Dao : BinAff.Core.Dao
    {
       public Dao(Data data)
           : base(data)
       {

       }

       protected override void Compose()
       {
           base.CreateStoredProcedure = "Configuration.ReligionInsert";
           base.ReadStoredProcedure = "Configuration.ReligionRead";
           base.ReadAllStoredProcedure = "Configuration.ReligionReadAll";
           base.UpdateStoredProcedure = "Configuration.ReligionUpdate";
           base.NumberOfRowsAffectedInUpdate = 1;
           base.DeleteStoredProcedure = "Configuration.ReligionDelete";
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

    }
}
