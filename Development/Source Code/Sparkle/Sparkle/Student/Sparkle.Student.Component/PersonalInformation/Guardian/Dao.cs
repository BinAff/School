using System;
using System.Collections.Generic;
using System.Data;

using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.PersonalInformation.Guardian
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Student.GuardianInsert";
            base.ReadStoredProcedure = "Student.GuardianRead";
            base.ReadAllStoredProcedure = "Student.GuardianReadAll";
            base.ReadForParentStoredProcedure = "Student.GuardianReadForParent";
            base.UpdateStoredProcedure = "Student.GuardianUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Student.GuardianDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Profile = new Conf.Profile.Data
            {
                Id = Convert.IsDBNull(dr["ProfileId"]) ? 0 : Convert.ToInt64(dr["ProfileId"]),
            };
            dt.Relationship = new Conf.Relationship.Data
            {
                Id = Convert.IsDBNull(dr["RelationshipId"]) ? 0 : Convert.ToInt64(dr["RelationshipId"]),
            };
            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@ProfileId", DbType.Int64, (this.Data as Data).Profile.Id);
            base.AddInParameter("@RelationshipId", DbType.String, (this.Data as Data).Relationship.Id);
            base.AddInParameter("@PersonalInformationId", DbType.String, (this.ParentData as PersonalInformation.Data).Id);
        }

        protected override void AttachChildrenDataToParent(System.Collections.Generic.List<BinAff.Core.Data> dataList)
        {
            if (dataList.Count > 0)
            {
                (this.ParentData as PersonalInformation.Data).GuardianList = new List<BinAff.Core.Data>();
                foreach (BinAff.Core.Data data in dataList)
                {
                    (this.ParentData as PersonalInformation.Data).GuardianList.Add(data);
                }
            }
        }

    }

}