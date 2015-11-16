using Comp = Crystal.Configuration.Component.IdentityProofType;

namespace Sparkle.Configuration.Facade.IdentityProofType
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        #region Framework

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
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Name = dto.Name;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
            };
        }

        public override void LoadForm()
        {
            (this.FormDto as FormDto).DtoList = new Server(null).ReadAll<Dto>().ConvertAll<Core.Facade.Dto>(new System.Converter<Dto, Core.Facade.Dto>((p) => { return p as Core.Facade.Dto; }));
        }

        #endregion

    }

}