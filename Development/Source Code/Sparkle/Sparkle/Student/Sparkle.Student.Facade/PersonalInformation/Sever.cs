using System.Collections.Generic;

using AppChache = BinAff.Facade.Cache.Server;

using Conf = Crystal.Configuration.Component;

using FacLib = Sparkle.Core.Facade;

using ConfFac = Sparkle.Configuration.Facade;
using Comp = Sparkle.Student.Component.PersonalInformation;

namespace Sparkle.Student.Facade.PersonalInformation
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
            dto.DateOfBirth = data.DateOfBirth;
            dto.BirthPlace = data.BirthPlace;
            dto.MotherTongue = new ConfFac.MotherTongue.Server(null).Convert(data.MotherTongue) as ConfFac.MotherTongue.Dto;
            dto.Religion = new ConfFac.Religion.Server(null).Convert(data.Religion) as ConfFac.Religion.Dto;
            dto.Caste = new ConfFac.Caste.Server(null).Convert(data.Caste) as ConfFac.Caste.Dto;
            dto.SubCaste = new ConfFac.SubCaste.Server(null).Convert(data.SubCaste) as ConfFac.SubCaste.Dto;
            dto.Gender = new ConfFac.Gender.Server(null).Convert(data.Gender) as ConfFac.Gender.Dto;
            dto.CurrentAddress = new ConfFac.ContactInformation.Server(null).Convert(data.PresentAddress) as ConfFac.ContactInformation.Dto;
            dto.PermanentAddress = new ConfFac.ContactInformation.Server(null).Convert(data.PermanentAddress) as ConfFac.ContactInformation.Dto;
            dto.GuardianList = new Guardian.Server(null).ConvertAll<BinAff.Core.Data, BinAff.Facade.Library.Dto>(data.GuardianList);
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Id = dto.Id;
            data.DateOfBirth = dto.DateOfBirth;
            data.BirthPlace = dto.BirthPlace;
            data.MotherTongue = new ConfFac.MotherTongue.Server(null).Convert(dto.MotherTongue) as Conf.MotherTongue.Data;
            data.Religion = new ConfFac.Religion.Server(null).Convert(dto.Religion) as Conf.Religion.Data;
            data.Caste = new ConfFac.Caste.Server(null).Convert(dto.Caste) as Conf.Caste.Data;
            data.SubCaste = new ConfFac.SubCaste.Server(null).Convert(dto.SubCaste) as Conf.SubCaste.Data;
            data.Gender = new ConfFac.Gender.Server(null).Convert(dto.Gender) as Conf.Gender.Data;
            data.PresentAddress = new ConfFac.ContactInformation.Server(null).Convert(dto.CurrentAddress) as Conf.ContactInformation.Data;
            data.PermanentAddress = new ConfFac.ContactInformation.Server(null).Convert(dto.PermanentAddress) as Conf.ContactInformation.Data;
            data.GuardianList = new Guardian.Server(null).ConvertAll<BinAff.Core.Data, BinAff.Facade.Library.Dto>(dto.GuardianList);
        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                DateOfBirth = dt.DateOfBirth,
                BirthPlace = dt.BirthPlace,
                MotherTongue = new ConfFac.MotherTongue.Server(null).Convert(dt.MotherTongue) as ConfFac.MotherTongue.Dto,
                Religion = new ConfFac.Religion.Server(null).Convert(dt.Religion) as ConfFac.Religion.Dto,
                Caste = new ConfFac.Caste.Server(null).Convert(dt.Caste) as ConfFac.Caste.Dto,
                SubCaste = new ConfFac.SubCaste.Server(null).Convert(dt.SubCaste) as ConfFac.SubCaste.Dto,
                Gender = new ConfFac.Gender.Server(null).Convert(dt.Gender) as ConfFac.Gender.Dto,
                CurrentAddress = new ConfFac.ContactInformation.Server(null).Convert(dt.PresentAddress) as ConfFac.ContactInformation.Dto,
                PermanentAddress = new ConfFac.ContactInformation.Server(null).Convert(dt.PermanentAddress) as ConfFac.ContactInformation.Dto,
                GuardianList = new Guardian.Server(null).ConvertAll<BinAff.Core.Data, BinAff.Facade.Library.Dto>(dt.GuardianList),
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                DateOfBirth = dt.DateOfBirth,
                BirthPlace = dt.BirthPlace,
                MotherTongue = new ConfFac.MotherTongue.Server(null).Convert(dt.MotherTongue) as Conf.MotherTongue.Data,
                Religion = new ConfFac.Religion.Server(null).Convert(dt.Religion) as Conf.Religion.Data,
                Caste = new ConfFac.Caste.Server(null).Convert(dt.Caste) as Conf.Caste.Data,
                SubCaste = new ConfFac.SubCaste.Server(null).Convert(dt.SubCaste) as Conf.SubCaste.Data,
                Gender = new ConfFac.Gender.Server(null).Convert(dt.Gender) as Conf.Gender.Data,
                PresentAddress = new ConfFac.ContactInformation.Server(null).Convert(dt.CurrentAddress) as Conf.ContactInformation.Data,
                PermanentAddress = new ConfFac.ContactInformation.Server(null).Convert(dt.PermanentAddress) as Conf.ContactInformation.Data,
                GuardianList = new Guardian.Server(null).ConvertAll<BinAff.Core.Data, BinAff.Facade.Library.Dto>(dt.GuardianList),
            };
        }

        public override void LoadListForControl()
        {
            (this.FormDto as FormDto).GenderList = AppChache.Current.Cache["GenderList"] as List<ConfFac.Gender.Dto>;
            (this.FormDto as FormDto).MotherTongueList = AppChache.Current.Cache["MotherTongueList"] as List<ConfFac.MotherTongue.Dto>;
            (this.FormDto as FormDto).ReligionList = AppChache.Current.Cache["ReligionList"] as List<ConfFac.Religion.Dto>;
            (this.FormDto as FormDto).CasteList = AppChache.Current.Cache["CasteList"] as List<ConfFac.Caste.Dto>;
            (this.FormDto as FormDto).SubCasteList = AppChache.Current.Cache["SubCasteList"] as List<ConfFac.SubCaste.Dto>;
        }

        #endregion

    }

}