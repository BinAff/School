using System.Collections.Generic;

using AppChache = BinAff.Facade.Cache.Server;

using Schl = Sparkle.School.Component;
using Comp = Sparkle.Student.Component;

using FacLib = Sparkle.Core.Facade;

using SchlFac = Sparkle.School.Facade;

namespace Sparkle.Student.Facade
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
            base.ComponentServer = new Sparkle.Student.Component.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            dto = this.Convert(base.ComponentData) as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            base.ComponentData.Id = data.Id;
            dto.FirstName = data.FirstName;
            dto.MiddleName = data.MiddleName;
            dto.LastName = data.LastName;
            dto.RollNumber = data.RollNumber;
            dto.Standard = new SchlFac.Standard.Server(null).Convert(data.Standard) as SchlFac.Standard.Dto;
            dto.Section = new SchlFac.Section.Server(null).Convert(data.Section) as SchlFac.Section.Dto;
            dto.PersonalInformation = new PersonalInformation.Server(null).Convert(data.PersonalInformation) as PersonalInformation.Dto;
            dto.Category = new Category.Server(null).Convert(data.Category) as Category.Dto;
        }

        public override void AssignData()
        {
            Dto dto = (this.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.FirstName = dto.FirstName;
            data.MiddleName = dto.MiddleName;
            data.LastName = dto.LastName;
            data.RollNumber = dto.RollNumber;
            data.Standard = new SchlFac.Standard.Server(null).Convert(dto.Standard) as Schl.Standard.Data;
            data.Section = new SchlFac.Section.Server(null).Convert(dto.Section) as Schl.Section.Data;
            data.PersonalInformation = new PersonalInformation.Server(null).Convert(dto.PersonalInformation) as Comp.PersonalInformation.Data;
            data.Category = new Category.Server(null).Convert(dto.Category) as Comp.Category.Data;
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                FirstName = dt.FirstName,
                MiddleName = dt.MiddleName,
                LastName = dt.LastName,
                RollNumber = dt.RollNumber,
                Standard = new SchlFac.Standard.Server(null).Convert(dt.Standard) as Schl.Standard.Data,
                Section = new SchlFac.Section.Server(null).Convert(dt.Section) as Schl.Section.Data,
                PersonalInformation = new PersonalInformation.Server(null).Convert(dt.PersonalInformation) as Comp.PersonalInformation.Data,
                Category = new Category.Server(null).Convert(dt.Category) as Comp.Category.Data,
            };
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                FirstName = dt.FirstName,
                MiddleName = dt.MiddleName,
                LastName = dt.LastName,
                RollNumber = dt.RollNumber,
                Standard = new SchlFac.Standard.Server(null).Convert(dt.Standard) as SchlFac.Standard.Dto,
                Section = new SchlFac.Section.Server(null).Convert(dt.Section) as SchlFac.Section.Dto,
                PersonalInformation = new PersonalInformation.Server(null).Convert(dt.PersonalInformation) as PersonalInformation.Dto,
                Category = new Category.Server(null).Convert(dt.Category) as Category.Dto,
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).StandardList = AppChache.Current.Cache["StandardList"] as List<SchlFac.Standard.Dto>;
            (this.FormDto as FormDto).SectionList = AppChache.Current.Cache["SectionList"] as List<SchlFac.Section.Dto>;
        }

        #endregion

    }

}