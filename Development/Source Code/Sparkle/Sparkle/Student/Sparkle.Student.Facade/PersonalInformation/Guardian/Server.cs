using FacLib = Sparkle.Core.Facade;

using Conf = Crystal.Configuration.Component;

using ConfFac = Sparkle.Configuration.Facade;

using Comp = Sparkle.Student.Component.PersonalInformation.Guardian;

namespace Sparkle.Student.Facade.PersonalInformation.Guardian
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
            dto.Profile = new ConfFac.Profile.Server(null).Convert(data.Profile) as ConfFac.Profile.Dto;
            dto.Relationship = new ConfFac.Relationship.Server(null).Convert(data.Relationship) as ConfFac.Relationship.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.Profile = new ConfFac.Profile.Server(null).Convert(dto.Profile) as Conf.Profile.Data;
            data.Relationship = new ConfFac.Relationship.Server(null).Convert(dto.Relationship) as Conf.Relationship.Data;
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Profile = new ConfFac.Profile.Server(null).Convert(dt.Profile) as ConfFac.Profile.Dto,
                Relationship = new ConfFac.Relationship.Server(null).Convert(dt.Relationship) as ConfFac.Relationship.Dto,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Profile = new ConfFac.Profile.Server(null).Convert(dt.Profile) as Conf.Profile.Data,
                Relationship = new ConfFac.Relationship.Server(null).Convert(dt.Relationship) as Conf.Relationship.Data,
            };
        }

        #endregion

    }

}