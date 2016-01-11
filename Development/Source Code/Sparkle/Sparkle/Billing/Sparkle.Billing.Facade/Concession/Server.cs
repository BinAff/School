using Comp = Sparkle.Billing.Component.Concession;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Billing.Facade.Concession
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
            dto.FeeDefinition = new Fee.Definition.Server(null).Convert(data.FeeDefinition) as Fee.Definition.Dto;
            dto.Caste = new Configuration.Facade.Caste.Server(null).Convert(data.Caste) as Configuration.Facade.Caste.Dto;
            dto.Amount = data.Amount;
            dto.IsPercentage = data.IsPercentage;
            
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.FeeDefinition = new Fee.Definition.Server(null).Convert(dto.FeeDefinition) as Sparkle.Billing.Component.Fee.Definition.Data;
            data.Caste = new Configuration.Facade.Caste.Server(null).Convert(dto.Caste) as Crystal.Configuration.Component.Caste.Data;
            data.Amount = dto.Amount;
            data.IsPercentage = dto.IsPercentage;
            
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                FeeDefinition = new Fee.Definition.Server(null).Convert(dt.FeeDefinition) as Fee.Definition.Dto,
                Caste = new Configuration.Facade.Caste.Server(null).Convert(dt.Caste) as Configuration.Facade.Caste.Dto,
                Amount = dt.Amount,
                IsPercentage = dt.IsPercentage,
                IsActive = dt.IsActive,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                FeeDefinition = new Fee.Definition.Server(null).Convert(dt.FeeDefinition) as Sparkle.Billing.Component.Fee.Definition.Data,
                Caste = new Configuration.Facade.Caste.Server(null).Convert(dt.Caste) as Crystal.Configuration.Component.Caste.Data,
                Amount = dt.Amount,
                IsPercentage = dt.IsPercentage,
                IsActive = dt.IsActive,
            };
        }

        #endregion

    }

}