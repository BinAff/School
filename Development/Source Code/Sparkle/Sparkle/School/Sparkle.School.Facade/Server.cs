using Comp = Sparkle.School.Component;
using ContInfo = Crystal.Configuration.Component.ContactInformation;

using FacLib = Sparkle.Core.Facade;

using ContInfoFac = Sparkle.Configuration.Facade.ContactInformation;

namespace Sparkle.School.Facade
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
            dto.ContactInformation = new ContInfoFac.Server(null).Convert(data.ContactInformation) as ContInfoFac.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Name = dto.Name;
            data.ContactInformation = new ContInfoFac.Server(null).Convert(dto.ContactInformation) as ContInfo.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                ContactInformation = new ContInfoFac.Server(null).Convert(dt.ContactInformation) as ContInfoFac.Dto,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                ContactInformation = new ContInfoFac.Server(null).Convert(dt.ContactInformation) as ContInfo.Data
            };
        }

        #endregion

    }

}