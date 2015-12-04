using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.PersonalInformation
{

    public class Server : BinAff.Core.Crud
    {

        public Server(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.Name = "Student's Personal Information";
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
            base.AddChild(new Conf.MotherTongue.Server((this.Data as Data).MotherTongue)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.Religion.Server((this.Data as Data).Religion)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.Caste.Server((this.Data as Data).Caste)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.SubCaste.Server((this.Data as Data).SubCaste)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.Gender.Server((this.Data as Data).Gender)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.ContactInformation.Server((this.Data as Data).CurrentAddress)
            {
                Type = ChildType.Independent,
            });
            base.AddChild(new Conf.ContactInformation.Server((this.Data as Data).PermanentAddress)
            {
                Type = ChildType.Independent,
            });
            base.AddChildren(new Guardian.Server(null)
            {
                Type = ChildType.Dependent,
            }, (this.Data as Data).GuardianList);
        }

    }

}