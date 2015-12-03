namespace Crystal.Configuration.Component.Mobile
{

    public class Server : BinAff.Core.Observer.SubjectCrud
    {

        public Server(Data data)
            : base(data)
        {

        }
        protected override void Compose()
        {
            this.Name = "Mobile Number";
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
            base.AddChild(new Country.Server((this.Data as Data).Country)
            {
                IsReadOnly = true,
                Type = ChildType.Independent
            });
        }

    }

}