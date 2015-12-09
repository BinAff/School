using System.Collections.Generic;

using AppChache = BinAff.Facade.Cache.Server;

using Schl = Sparkle.School.Facade;

using StateFac = Vanilla.Configuration.Facade.State;
using CountryFac = Vanilla.Configuration.Facade.Country;

using FacLib = Sparkle.Core.Facade;

using Comp = Sparkle.Student.Component;

namespace Sparkle.Student.Facade
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
            base.ComponentServer = new Sparkle.Student.Component.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            dto = this.Convert(base.ComponentData) as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            base.ComponentData.Id = data.Id;
            dto.FirstName = data.FirstName;
            dto.MiddleName = data.MiddleName;
            dto.LastName = data.LastName;
            //dto.Address = data.ResidentialAddress.Address;
            //dto.State = new StateFac.Server(null).Convert(data.ResidentialAddress.State) as StateFac.Dto;
            //dto.City = data.ResidentialAddress.City;
            //dto.Pin = data.ResidentialAddress.Pin;
        }

        public override void AssignData()
        {
            Dto dto = (this.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.FirstName = dto.FirstName;
            data.MiddleName = dto.MiddleName;
            data.LastName = dto.LastName;
            //data.ResidentialAddress.Address = dto.Address;
            //data.ResidentialAddress.State = new StateFac.Server(null).Convert(dto.State) as StateComp.Data;
            //data.ResidentialAddress.City = dto.City;
            //data.ResidentialAddress.Pin = dto.Pin;
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
                //ResidentialAddress = 
                //Address = dt.Address,
                //State = new StateFac.Server(null).Convert(dt.State) as StateComp.Data,
                //City = dt.City,
                //Pin = dt.Pin,
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
                //Address = dt.Address,
                //State = new StateFac.Server(null).Convert(dt.State) as StateFac.Dto,
                //City = dt.City,
                //Pin = dt.Pin,
            };
        }

        public override void LoadControl()
        {
            (this.FormDto as FormDto).StandardList = AppChache.Current.Cache["StandardList"] as List<Schl.Standard.Dto>;
            (this.FormDto as FormDto).SectionList = AppChache.Current.Cache["SectionList"] as List<Schl.Section.Dto>;
        }

        #endregion

    }

}