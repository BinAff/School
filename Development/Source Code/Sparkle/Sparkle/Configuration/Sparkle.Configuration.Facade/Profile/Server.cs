using System.Collections.Generic;

using Comp = Crystal.Configuration.Component.Profile;
using OcuComp = Crystal.Configuration.Component.Occupation;
using ContComp = Crystal.Configuration.Component.ContactInformation;
using MobileComp = Crystal.Configuration.Component.Mobile;

using AppCache = BinAff.Facade.Cache.Server;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Configuration.Facade.Profile
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
                Dto = new Dto
                {
                    ContactInformation = new ContactInformation.Dto(),
                },
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
            dto.FirstName = data.FirstName;
            dto.MiddleName = data.MiddleName;
            dto.LastName = data.LastName;
            dto.Occupation = new Occupation.Server(null).Convert(data.Occupation) as Occupation.Dto;
            dto.ContactInformation = new ContactInformation.Server(null).Convert(data.ContactInformation) as ContactInformation.Dto;
            dto.Mobile = new Mobile.Server(null).Convert(data.Mobile) as Mobile.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.FirstName = dto.FirstName;
            data.MiddleName = dto.MiddleName;
            data.LastName = dto.LastName;
            data.Occupation = new Occupation.Server(null).Convert(dto.Occupation) as OcuComp.Data;
            data.ContactInformation = new ContactInformation.Server(null).Convert(dto.ContactInformation) as ContComp.Data;
            data.Mobile = new Mobile.Server(null).Convert(dto.Mobile) as MobileComp.Data;
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
                Occupation = new Occupation.Server(null).Convert(dt.Occupation) as Occupation.Dto,
                ContactInformation = new ContactInformation.Server(null).Convert(dt.ContactInformation) as ContactInformation.Dto,
                Mobile = new Mobile.Server(null).Convert(dt.Mobile) as Mobile.Dto,
            };
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
                Occupation = new Occupation.Server(null).Convert(dt.Occupation) as OcuComp.Data,
                ContactInformation = new ContactInformation.Server(null).Convert(dt.ContactInformation) as ContComp.Data,
                Mobile = new Mobile.Server(null).Convert(dt.Mobile) as MobileComp.Data,
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).OccupationList = AppCache.Current.Cache["OccupationList"] as List<Occupation.Dto>;
        }

        #endregion

    }

}