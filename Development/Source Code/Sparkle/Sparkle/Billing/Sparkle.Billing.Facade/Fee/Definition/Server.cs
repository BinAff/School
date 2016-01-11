using BinAff.Facade.Library;
using Sparkle.Core;

using Comp = Sparkle.Billing.Component.Fee.Definition;

using FeeGroupComp = Sparkle.Billing.Component.Fee.Group;
//using FeeGroupFac = Sparkle.Billing.Facade.Fee.Group;

using FineDefComp = Sparkle.Billing.Component.Fine.Definition;
//using FineDefFac = Sparkle.Billing.Facade.Fine.Definition;


using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Billing.Facade.Fee.Definition
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
            dto.Name = data.Name;
            dto.FeeGroup = new Fee.Group.Server(null).Convert(data.FeeGroup) as Fee.Group.Dto;
            dto.FineDefination = new Fine.Definition.Server(null).Convert(data.FineDefination) as Fine.Definition.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Name = dto.Name;
            data.FeeGroup = new Fee.Group.Server(null).Convert(dto.FeeGroup) as FeeGroupComp.Data;
            data.FineDefination = new Fine.Definition.Server(null).Convert(dto.FineDefination) as FineDefComp.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                FeeGroup = new Fee.Group.Server(null).Convert(dt.FeeGroup) as Fee.Group.Dto,
                FineDefination = new Fine.Definition.Server(null).Convert(dt.FineDefination) as Fine.Definition.Dto,
                IsActive = dt.IsActive,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                FeeGroup = new Fee.Group.Server(null).Convert(dt.FeeGroup) as FeeGroupComp.Data,
                FineDefination = new Fine.Definition.Server(null).Convert(dt.FineDefination) as FineDefComp.Data,
                IsActive = dt.IsActive,
            };
        }

        #endregion

    }

}