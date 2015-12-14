using Comp = Sparkle.School.Component.Class;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.School.Facade.Class
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
            dto.Standard = new Standard.Server(null).Convert(data.Standard) as Standard.Dto;
            dto.Section = new Section.Server(null).Convert(data.Section) as Section.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Standard = new Standard.Server(null).Convert(dto.Standard) as Sparkle.School.Component.Standard.Data;
            data.Section = new Section.Server(null).Convert(dto.Section) as Sparkle.School.Component.Section.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Standard = new Standard.Server(null).Convert(dt.Standard) as Standard.Dto,
                Section = new Section.Server(null).Convert(dt.Section) as Section.Dto,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Standard = new Standard.Server(null).Convert(dt.Standard) as Sparkle.School.Component.Standard.Data,
                Section = new Section.Server(null).Convert(dt.Section) as Sparkle.School.Component.Section.Data
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).SectionList = new Section.Server(null).ReadAll<Section.Dto>();
            (this.FormDto as FormDto).StandardList = new Standard.Server(null).ReadAll<Standard.Dto>();
        }

        #endregion

    }

}