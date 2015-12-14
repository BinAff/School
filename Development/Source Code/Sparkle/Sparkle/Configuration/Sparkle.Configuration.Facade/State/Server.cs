using System.Collections.Generic;

using Comp = Crystal.Configuration.Component.State;
using CountryComp = Crystal.Configuration.Component.Country;

using AppCache = BinAff.Facade.Cache.Server;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Configuration.Facade.State
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        #region Framework

        protected override FacLib.FormDto InstantiateFormDto()
        {
            return new FormDto
            {
                Dto = new Dto(),
            };
        }

        protected override FacLib.Server InstantiateFacade()
        {
            return new Server(base.FormDto as FormDto);
        }

        protected override void Instantiate()
        {
            base.ComponentData = new Comp.Data();
            base.ComponentServer = new Comp.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            base.ComponentData.Id = data.Id;
            dto.Name = data.Name;
            dto.Country = new Country.Server(null).Convert(data.Country) as Country.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Name = dto.Name;
            data.Country = new Country.Server(null).Convert(dto.Country) as CountryComp.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                Country = new Country.Server(null).Convert(dt.Country) as Country.Dto,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                Country = new Country.Server(null).Convert(dt.Country) as CountryComp.Data,
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).CountryList = AppCache.Current.Cache["CountryList"] as List<Country.Dto>;
        }

        #endregion

    }

}