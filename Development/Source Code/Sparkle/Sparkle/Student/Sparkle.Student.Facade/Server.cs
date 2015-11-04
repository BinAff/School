using StateComp = Crystal.Configuration.Component.State;
using CountryComp = Crystal.Configuration.Component.Country;

using StateFac = Vanilla.Configuration.Facade.State;
using CountryFac = Vanilla.Configuration.Facade.Country;

using Comp = Sparkle.Student.Component;
using System.Collections.Generic;

namespace Sparkle.Student.Facade
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        protected override void Instantiate()
        {
            base.ComponentData = new Comp.Data();
            base.ComponentServer = new Sparkle.Student.Component.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            (base.FormDto as FormDto).Dto = this.Convert(base.ComponentData) as Dto;
            Comp.Data dt = base.ComponentData as Comp.Data;
            base.ComponentData.Id = dt.Id;
            ((base.FormDto as FormDto).Dto as Dto).FirstName = dt.FirstName;
            ((base.FormDto as FormDto).Dto as Dto).MiddleName = dt.MiddleName;
            ((base.FormDto as FormDto).Dto as Dto).LastName = dt.LastName;
            ((base.FormDto as FormDto).Dto as Dto).Address = dt.Address;
            ((base.FormDto as FormDto).Dto as Dto).State = new StateFac.Server(null).Convert(dt.State) as StateFac.Dto;
        }

        public override void AssignData()
        {
            Dto dt = (this.FormDto as FormDto).Dto as Dto;
            base.ComponentData.Id = dt.Id;
            (base.ComponentData as Comp.Data).FirstName = dt.FirstName;
            (base.ComponentData as Comp.Data).MiddleName = dt.MiddleName;
            (base.ComponentData as Comp.Data).LastName = dt.LastName;
            (base.ComponentData as Comp.Data).Address = dt.Address;
            (base.ComponentData as Comp.Data).State = new StateFac.Server(null).Convert(dt.State) as StateComp.Data;
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
                Address = dt.Address,
                State = new StateFac.Server(null).Convert(dt.State) as StateComp.Data,
                City = dt.City,
                Pin = dt.Pin,
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
                Address = dt.Address,
                State = new StateFac.Server(null).Convert(dt.State) as StateFac.Dto,
                City = dt.City,
                Pin = dt.Pin,
            };
        }

        public override void LoadForm()
        {
            (this.FormDto as FormDto).DtoList = new Server(null).ReadAll<Dto>().ConvertAll<Core.Facade.Dto>(new System.Converter<Dto, Core.Facade.Dto>((p) => { return p as Core.Facade.Dto; }));
            (this.FormDto as FormDto).StateList = new StateFac.Server(null).ReadAll<StateFac.Dto>();
            (this.FormDto as FormDto).CountryList = new CountryFac.Server(null).ReadAll<CountryFac.Dto>();
        }
        
    }

}