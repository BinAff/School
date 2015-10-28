using StateComp = Crystal.Configuration.Component.State;

using StateFac = Vanilla.Configuration.Facade.State;

using Comp = Sparkle.Student.Component;

namespace Sparkle.Student.Facade
{

    public class Server : BinAff.Facade.Library.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                FirstName = dt.FirstName,
                MiddleName = dt.MiddleName,
                LastName = dt.LastName,
                State = new StateFac.Server(null).Convert(dt.State) as StateComp.Data
            };
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                FirstName = dt.FirstName,
                MiddleName = dt.MiddleName,
                LastName = dt.LastName,
                State = new StateFac.Server(null).Convert(dt.State) as StateFac.Dto
            };
        }

        public override void LoadForm()
        {
            (this.FormDto as FormDto).StateList = new StateFac.Server(null).ReadAll<StateFac.Dto>();
        }

    }

}