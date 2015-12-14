using System.Collections.Generic;

using Comp = Crystal.Configuration.Component.ContactInformation;
using DistrictComp = Crystal.Configuration.Component.District;

using AppCache = BinAff.Facade.Cache.Server;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Configuration.Facade.ContactInformation
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
            dto.Address = data.Address;
            dto.District = new District.Server(null).Convert(data.District) as District.Dto;
            dto.Pin = data.Pin;
            dto.Landline = data.Landline;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Address = dto.Address;
            data.District = new District.Server(null).Convert(dto.District) as DistrictComp.Data;
            data.Pin = dto.Pin;
            data.Landline = dto.Landline;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Address = dt.Address,
                District = new District.Server(null).Convert(dt.District) as District.Dto,
                Pin = dt.Pin,
                Landline = dt.Landline,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Address = dt.Address,
                District = new District.Server(null).Convert(dt.District) as DistrictComp.Data,
                Pin = dt.Pin,
                Landline = dt.Landline,
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).CountryList = AppCache.Current.Cache["CountryList"] as List<Country.Dto>;
            (this.FormDto as FormDto).StateList = AppCache.Current.Cache["StateList"] as List<State.Dto>;
            (this.FormDto as FormDto).DistrictList = AppCache.Current.Cache["DistrictList"] as List<District.Dto>;
        }

        #endregion

    }

}