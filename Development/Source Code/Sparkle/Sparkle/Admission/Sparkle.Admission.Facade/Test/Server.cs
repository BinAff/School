using Comp = Sparkle.Admission.Component.Test;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Admission.Facade.Test
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
            dto.TotalMarks = data.TotalMarks;
            dto.IsPassed = data.IsPassed;
            dto.Rank = data.Rank;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.TotalMarks = dto.TotalMarks;
            data.IsPassed = dto.IsPassed;
            data.Rank = dto.Rank;

        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                TotalMarks = dt.TotalMarks,
                IsPassed = dt.IsPassed,
                Rank = dt.Rank,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                TotalMarks = dt.TotalMarks,
                IsPassed = dt.IsPassed,
                Rank = dt.Rank,
            };
        }

        #endregion

    }

}