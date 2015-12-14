using System;

using BinAff.Presentation.Library.Extension;

using Conf = Sparkle.Configuration.Facade;

using Fac = Sparkle.Student.Facade.PersonalInformation;

namespace Sparkle.Student.WinForm.PersonalInformation
{

    public partial class FormControl : Sparkle.Core.Presentation.FormControl
    {

        public FormControl()
        {
            InitializeComponent();
        }

        protected override Core.Facade.Server InstantiateFacade()
        {
            return new Fac.Server(base.FormDto as Fac.FormDto);
        }

        protected override void AttachDtoToChildControl()
        {
            this.ucCurrentAddress.FormDto.Dto = ((this.FormDto as Fac.FormDto).Dto as Fac.Dto).CurrentAddress;
            this.ucPermanantAddress.FormDto.Dto = ((this.FormDto as Fac.FormDto).Dto as Fac.Dto).PermanentAddress;
        }

        protected override void Bind()
        {
            this.cboGender.Bind((this.FormDto as Fac.FormDto).GenderList, "Name");
            this.cboMotherTongue.Bind((this.FormDto as Fac.FormDto).MotherTongueList, "Name");
            this.cboReligion.Bind((this.FormDto as Fac.FormDto).ReligionList, "Name");
            this.cboCaste.Bind((this.FormDto as Fac.FormDto).CasteList, "Name");
            this.cboSubCaste.Bind((this.FormDto as Fac.FormDto).SubCasteList, "Name");
        }

        protected override void ClearForm()
        {
            this.dtpDateOfBirth.Value = DateTime.Now;
            this.txtPlaceOfBirth.Text = String.Empty;
            this.cboGender.SelectedIndex = -1;
            this.cboGender.Text = String.Empty;
            this.cboMotherTongue.SelectedIndex = -1;
            this.cboMotherTongue.Text = String.Empty;
            this.cboReligion.SelectedIndex = -1;
            this.cboReligion.Text = String.Empty;
            this.cboCaste.SelectedIndex = -1;
            this.cboCaste.Text = String.Empty;
            this.cboSubCaste.SelectedIndex = -1;
            this.cboSubCaste.Text = String.Empty;
            this.dtpDateOfBirth.Focus();
        }

        protected override void AssignDto()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            dto.DateOfBirth = this.dtpDateOfBirth.Value;
            dto.BirthPlace = this.txtPlaceOfBirth.Text.Trim();
            dto.Gender = this.cboGender.SelectedItem as Conf.Gender.Dto;
            dto.MotherTongue = this.cboMotherTongue.SelectedItem as Conf.MotherTongue.Dto;
            dto.Religion = this.cboReligion.SelectedItem as Conf.Religion.Dto;
            dto.Caste = this.cboCaste.SelectedItem as Conf.Caste.Dto;
            dto.SubCaste = this.cboSubCaste.SelectedItem as Conf.SubCaste.Dto;
        }

        protected override void AssignFormControls()
        {
            Fac.Dto dto = base.FormDto.Dto as Fac.Dto;
            this.dtpDateOfBirth.Value = dto.DateOfBirth;
            this.txtPlaceOfBirth.Text = dto.BirthPlace;
            this.cboGender.SelectedItem = (this.FormDto as Fac.FormDto).GenderList.FindLast((p) => { return p.Id == dto.Gender.Id; });
            this.cboMotherTongue.SelectedItem = (this.FormDto as Fac.FormDto).MotherTongueList.FindLast((p) => { return p.Id == dto.MotherTongue.Id; });
            this.cboReligion.SelectedItem = (this.FormDto as Fac.FormDto).ReligionList.FindLast((p) => { return p.Id == dto.Religion.Id; });
            this.cboCaste.SelectedItem = (this.FormDto as Fac.FormDto).CasteList.FindLast((p) => { return p.Id == dto.Caste.Id; });
            this.cboSubCaste.SelectedItem = (this.FormDto as Fac.FormDto).SubCasteList.FindLast((p) => { return p.Id == dto.SubCaste.Id; });
        }

        protected override Boolean ValidateForm()
        {

            return true;
        }

    }

}