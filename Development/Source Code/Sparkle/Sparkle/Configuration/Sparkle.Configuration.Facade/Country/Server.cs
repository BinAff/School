using Comp = Crystal.Configuration.Component.Country;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Configuration.Facade.Country
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
            if (data != null)
            {
                base.ComponentData.Id = data.Id;
                dto.Name = data.Name;
                dto.Code = data.Code;
                dto.IsdCode = data.IsdCode;
            }
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            if (dto != null)
            {
                data.Id = dto.Id;
                data.Name = dto.Name;
                data.Code = dto.Code;
                data.IsdCode = dto.IsdCode;
            }
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            if (data == null) return null;
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                Code = dt.Code,
                IsdCode = dt.IsdCode,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            if (dto == null) return null;
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                Code = dt.Code,
                IsdCode = dt.IsdCode,
            };
        }
        
        #endregion

    }

}