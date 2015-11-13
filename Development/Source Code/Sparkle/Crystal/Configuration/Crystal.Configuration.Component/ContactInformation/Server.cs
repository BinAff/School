using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal.Configuration.Component.ContactInformation
{
    public class Server : BinAff.Core.Observer.SubjectCrud
    {
        public Server(Data data)
            : base(data)
        {

        }
        protected override void Compose()
        {
            this.Name = "ContactInformation";
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
            base.AddChild(new State.Server((this.Data as Data).State)
            {
                IsReadOnly = true,
                Type = ChildType.Independent
            });
        }
    }
}
