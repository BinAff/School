using FacLib = Sparkle.Core.Facade;

using Comp = Sparkle.Billing.Component.Fee;

using SchComp = Sparkle.School.Component;

using StuComp = Sparkle.Student.Component;

using Fac = Sparkle.Billing.Facade.Fee;

using SchFac = Sparkle.School.Facade;

using StuFac = Sparkle.Student.Facade;

namespace Sparkle.Billing.Facade.Fee
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
            dto.FeeGroup = new Fac.Group.Server(null).Convert(data.FeeGroup) as Group.Dto;
            dto.FeeDefination = new Definition.Server(null).Convert(data.FeeDefination) as Definition.Dto;
            dto.SchoolStandard = new SchFac.Standard.Server(null).Convert(data.SchoolStandard) as SchFac.Standard.Dto;
            dto.Category = new StuFac.Category.Server(null).Convert(data.Category) as StuFac.Category.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Amount = dto.Amount;
            data.FeeGroup = new Fac.Group.Server(null).Convert(dto.FeeGroup) as Comp.Group.Data;
            data.FeeDefination = new Definition.Server(null).Convert(dto.FeeDefination) as Comp.Definition.Data;
            data.SchoolStandard = new SchFac.Standard.Server(null).Convert(dto.SchoolStandard) as SchComp.Standard.Data;
            data.Category = new StuFac.Category.Server(null).Convert(dto.Category) as StuComp.Category.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Amount = dt.Amount,
                FeeGroup = new Fac.Group.Server(null).Convert(dt.FeeGroup) as Group.Dto,
                FeeDefination = new Definition.Server(null).Convert(dt.FeeDefination) as Definition.Dto,
                SchoolStandard = new SchFac.Standard.Server(null).Convert(dt.SchoolStandard) as SchFac.Standard.Dto,
                Category = new StuFac.Category.Server(null).Convert(dt.Category) as StuFac.Category.Dto,
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
                FeeGroup = new Fac.Group.Server(null).Convert(dt.FeeGroup) as Comp.Group.Data,
                FeeDefination = new Definition.Server(null).Convert(dt.FeeDefination) as Comp.Definition.Data,
                SchoolStandard = new SchFac.Standard.Server(null).Convert(dt.SchoolStandard) as SchComp.Standard.Data,
                Category = new StuFac.Category.Server(null).Convert(dt.Category) as StuComp.Category.Data,
                IsActive = dt.IsActive,
            };
        }

        #endregion

    }

}