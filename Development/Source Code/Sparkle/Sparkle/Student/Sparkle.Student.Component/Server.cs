using System;

using Schl = Sparkle.School.Component;

namespace Sparkle.Student.Component
{

    public class Server : BinAff.Core.Crud
    {

        public Server(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.Name = "Student";
            base.Validator = new Validator(this.Data as Data);
            base.DataAccess = new Dao(this.Data as Data);
        }

        public override BinAff.Core.Data CreateDataObject()
        {
            return new Data();
        }

        public override BinAff.Core.Crud CreateInstance(BinAff.Core.Data data)
        {
            return new Server(data as Data);
        }

        protected override void CreateChildren()
        {
            base.AddChild(new Category.Server((this.Data as Data).Category)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Schl.Standard.Server((this.Data as Data).Standard)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Schl.Section.Server((this.Data as Data).Section)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new PersonalInformation.Server((this.Data as Data).PersonalInformation)
            {
                Type = ChildType.Dependent,
            });
            base.AddChildren(new Guardian.Server(null)
            {
                Type = ChildType.Dependent,
            }, (this.Data as Data).GuardianList);
        }

        protected override BinAff.Core.ReturnObject<Boolean> CreateBefore()
        {
            (this.Data as Data).StudentId = String.Format("STUD-{0}-1", DateTime.Today.Year);//Need algorithm
            return new BinAff.Core.ReturnObject<Boolean>
            {
                Value = true,
            };
        }

        protected override BinAff.Core.ReturnObject<Boolean> UpdateBefore()
        {
            (this.Data as Data).StudentId = String.Format("STUD-{0}-1", DateTime.Today.Year);//Need algorithm
            return new BinAff.Core.ReturnObject<Boolean>
            {
                Value = true,
            };
        }

    }

}