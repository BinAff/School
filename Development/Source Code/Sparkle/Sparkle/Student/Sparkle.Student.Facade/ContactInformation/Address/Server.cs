using System;

//using Comp = Crystal.Configuration.Component;

namespace Sparkle.Student.Facade.ContactInformation.Address
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        protected override void Instantiate()
        {
            //base.ComponentData = new Comp.Data();
            //base.ComponentServer = new Sparkle.Student.Component.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            throw new NotImplementedException();
        }

        public override void AssignData()
        {
            throw new NotImplementedException();
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            throw new NotImplementedException();
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            throw new NotImplementedException();
        }

        public override void LoadForm()
        {
            throw new NotImplementedException();
        }

    }

}