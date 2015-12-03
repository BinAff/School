namespace Crystal.Configuration.Component.Profile
{

    public class Server : BinAff.Core.Observer.SubjectCrud
    {

        public Server(Data data)
            : base(data)
        {

        }
        protected override void Compose()
        {
            this.Name = "Guardian Profile";
            this.DataAccess = new Dao(this.Data as Data);
            this.Validator = new Validator(this.Data as Data);
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
            base.AddChild(new Crystal.Configuration.Component.Occupation.Server((this.Data as Data).Occupation)
            {
                IsReadOnly = true,
                Type = ChildType.Independent
            });
            base.AddChild(new Crystal.Configuration.Component.ContactInformation.Server((this.Data as Data).ContactInformation)
            {
                Type = ChildType.Independent
            });
            base.AddChild(new Crystal.Configuration.Component.Mobile.Server((this.Data as Data).Mobile)
            {
                Type = ChildType.Dependent
            });
        }

    }

}