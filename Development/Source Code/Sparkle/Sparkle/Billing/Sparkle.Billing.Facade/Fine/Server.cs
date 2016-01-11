using Comp = Sparkle.Billing.Component.Fine;

using SchComp = Sparkle.School.Component;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Billing.Facade.Fine
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
            dto.Amount = data.Amount;
            //dto.FineType = new Type.Server(null).Convert(data.FineType) as Fine.Type.Dto;
            dto.Definition = new Definition.Server(null).Convert(data.Definition) as Fine.Definition.Dto;
            dto.SchoolStandard = new School.Facade.Standard.Server(null).Convert(data.SchoolStandard) as School.Facade.Standard.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Amount = dto.Amount;
            //data.FineType = new Type.Server(null).Convert(dto.FineType) as Comp.Type.Data;
            data.Definition = new Definition.Server(null).Convert(dto.Definition) as Comp.Definition.Data;
            data.SchoolStandard = new School.Facade.Standard.Server(null).Convert(dto.SchoolStandard) as School.Component.Standard.Data;
            
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Amount = dt.Amount,
                //FineType = new Type.Server(null).Convert(dt.FineType) as Fine.Type.Dto,
                Definition = new Definition.Server(null).Convert(dt.Definition) as Fine.Definition.Dto,
                SchoolStandard = new School.Facade.Standard.Server(null).Convert(dt.SchoolStandard) as School.Facade.Standard.Dto,
                IsActive = dt.IsActive,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Amount = dt.Amount,
                //FineType = new Type.Server(null).Convert(dt.FineType) as Comp.Type.Data,
                Definition = new Definition.Server(null).Convert(dt.Definition) as Comp.Definition.Data,
                SchoolStandard = new School.Facade.Standard.Server(null).Convert(dt.SchoolStandard) as School.Component.Standard.Data,
                IsActive = dt.IsActive,
            };
        }

        #endregion

    }

}