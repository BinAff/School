using Conf = Crystal.Configuration.Component;

namespace Sparkle.Student.Component.Guardian
{

    public class Server : BinAff.Core.Crud
    {

        public Server(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.Name = "Student's Guardian";
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
            base.AddChild(new Conf.Relationship.Server((this.Data as Data).Relationship)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Conf.Profile.Server((this.Data as Data).Profile)
            {
                Type = ChildType.Independent,
            });
        }

    }

}