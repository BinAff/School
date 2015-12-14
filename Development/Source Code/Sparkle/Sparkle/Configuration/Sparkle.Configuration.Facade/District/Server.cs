using System.Collections.Generic;

using Comp = Crystal.Configuration.Component.District;
using StateComp = Crystal.Configuration.Component.State;

using AppCache = BinAff.Facade.Cache.Server;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.Configuration.Facade.District
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
            dto.State = new State.Server(null).Convert(data.State) as State.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Name = dto.Name;
            data.State = new State.Server(null).Convert(dto.State) as StateComp.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                State = new State.Server(null).Convert(dt.State) as State.Dto,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                State = new State.Server(null).Convert(dt.State) as StateComp.Data,
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).StateList = AppCache.Current.Cache["StateList"] as List<State.Dto>;
        }

        #endregion

    }

}